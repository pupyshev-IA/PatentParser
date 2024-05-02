using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Parser.Models.FileOperations;
using Parser.Models.main;
using Parser.Models.Parsers;
using Parser.UI.main;

namespace Parser.UI.Parsers
{
    public partial class WIPO : Form
    {
        private string excelFilePath = @"../Результаты поиска/WIPO/";
        private string txtFilePath = @"../search_info/WIPO/";
        private string fileName = "";

        Dictionary<string, string> formData;
        Dictionary<string, List<string>> forExcel;

        private SelectingFileName fileNameSelect;
        private PatentDatabaseParser parser;
        private ExcelFiles excel;
        private TextFiles txt;
        private FileExplorer fileExplorer;


        public WIPO()
        {
            InitializeComponent();
            excel = new ExcelFiles();
            txt = new TextFiles();
            fileExplorer = FileExplorer.getInstance();
        }

        private void ParseData(Object stateInfo)
        {
            if (InternetConnection.IsInternetConnected())
            {
                fileNameSelect = new SelectingFileName(excelFilePath, txtFilePath);
                fileNameSelect.ShowDialog();

                if (fileNameSelect.IsAcceptStatus())
                {
                    formData = new Dictionary<string, string>
                    {
                        { "AnyField", tbAnyField.Text },
                        { "Name", tbName.Text },
                        { "Text", tbText.Text },
                        { "Author", tbAuthor.Text },
                        { "Inventor", tbInventor.Text },
                        { "Country", tbCountry.Text },
                        { "RequestNum", tbRequestNum.Text },
                        { "PriorityNum", tbPriorityNum.Text },
                        { "PublicationNum", tbPublicationNum.Text },
                        { "SubmissionDate", tbSubmissionDate.Text },
                        { "PublicationDate", tbPublicationDate.Text },
                        { "PriorityDate", tbPriorityDate.Text },
                        { "MPKClass", tbMPKClass.Text },
                        { "MPKCode", tbMPKCode.Text },
                        { "Language", tbLanguage.Text },
                        { "DepartmentCode", tbDepartmentCode.Text },
                        { "Publisher", tbPublisher.Text },
                        { "Formula", tbFormula.Text },
                        { "DocAmount", tbDocAmount.Text }
                    };

                    fileName = fileNameSelect.GetFileName();

                    parser = new PatentDatabaseParser();
                    forExcel = parser.ParseWipo(formData);

                    bool isSuccess = excel.CreateExcelFile(forExcel, excelFilePath, fileName);

                    if (isSuccess)
                    {
                        txt.CreateTextFile(formData, txtFilePath, fileName);

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            // Код для выполнения в UI-потоке
                            fileExplorer.UpdateFileExplorer();
                            fileExplorer.SelectNewFile(fileName);
                        });
                    }
                    else
                    {
                        MessageBox.Show("По данному запросу ничего не найдено." +
                            "\nПопробуйте изменить запрос или воспользоваться другими поисковыми системами.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте подключение к Интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(ParseData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control el in tableLayoutPanelCenter.Controls)
            {
                if (el is KryptonTextBox)
                    el.Text = "";
            }

            tbDocAmount.Text = "";
        }
    }
}
