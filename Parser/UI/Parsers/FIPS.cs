using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Parser.Models.FileOperations;
using Parser.Models.main;
using Parser.Models.Parsers;

namespace Parser.UI.Parsers
{
    public partial class FIPS : Form
    {
        private string excelFilePath = @"../Результаты поиска/ФИПС/";
        private string txtFilePath = @"../search_info/ФИПС/";
        private string fileName = "";

        Dictionary<string, string> formData;
        Dictionary<string, List<string>> forExcel;
        private SelectingFileName fileNameSelect;
        private SeleniumParsers parser;
        private ExcelFiles excel;
        private TextFiles txt;
        private FileExplorer fileExplorer;


        public FIPS()
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
                        { "Keys", tbKeys.Text },
                        { "Name", tbName.Text },
                        { "DocNum", tbDocNum.Text },
                        { "Date", tbDate.Text },
                        { "MPK", tbMPK.Text },
                        { "Applicant", tbApplicant.Text },
                        { "Author", tbAuthor.Text },
                        { "Patentee", tbPatentee.Text },
                        { "PublicationDate", tbPublicationDate.Text },
                        { "DateRTS", tbDateRTS.Text },
                        { "NumRTS", tbNumRTS.Text },
                        { "Correspondence", tbCorrespondence.Text },
                        { "ViewCode", tbViewCode.Text },
                        { "RegNum", tbRegNum.Text },
                        { "ApplicationDate", tbApplicationDate.Text },
                        { "ConventionPriority", tbConventionPriority.Text },
                        { "ConventionDate", tbConventionDate.Text },
                        { "PriorityCountry", tbPriorityCountry.Text },
                        { "Essay", tbEssay.Text },
                        { "Formula", tbFormula.Text },
                        { "DocAmount", tbDocAmount.Text }
                    };

                    fileName = fileNameSelect.GetFileName();

                    parser = new SeleniumParsers();
                    forExcel = parser.ParseFips(formData);

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
                MessageBox.Show("Проверьте подключение к Интеренету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
