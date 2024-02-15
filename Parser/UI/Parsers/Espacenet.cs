using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Parser.Models.main;
using Parser.Models.Parsers;

namespace Parser.UI.Parsers
{
    public partial class Espacenet : Form
    {
        private string filePath = @"../Результаты поиска/Espacenet/";
        private string fileName = "";

        Dictionary<string, string> formData;
        Dictionary<string, List<string>> forExcel;
        private SelectingFileName fileNameSelect;
        private EspacenetParser parser;
        private ExcelFiles excel;
        private FileExplorer fileExplorer;


        public Espacenet()
        {
            InitializeComponent();
            excel = new ExcelFiles();
            fileExplorer = FileExplorer.getInstance();
        }

        private void ParseData(Object stateInfo)
        {
            if (InternetConnection.IsInternetConnected())
            {
                fileNameSelect = new SelectingFileName(filePath);
                fileNameSelect.ShowDialog();

                if (fileNameSelect.IsAcceptStatus())
                {
                    formData = new Dictionary<string, string>
                    {
                        { "KeysName", tbKeysName.Text },
                        { "KeysText", tbKeysText.Text },
                        { "PublicationNum", tbPublicationNum.Text },
                        { "ApplicationNum", tbApplicationNum.Text },
                        { "DocNum", tbDocNum.Text },
                        { "Date", tbDate.Text },
                        { "Applicant", tbApplicant.Text },
                        { "Inventor", tbInventor.Text },
                        { "SRS", tbSRS.Text },
                        { "MPK", tbMPK.Text },
                        { "DocAmount", tbDocAmount.Text }
                    };

                    fileName = fileNameSelect.GetFileName();

                    parser = new EspacenetParser();
                    forExcel = parser.ParseEspacenet(formData);

                    bool isSuccess = excel.CreateExcelFile(forExcel, filePath, fileName);

                    if (isSuccess)
                    {
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
