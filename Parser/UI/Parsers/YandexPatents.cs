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
    public partial class YandexPatents : Form
    {
        private string excelFilePath = @"../Результаты поиска/Яндекс.Патенты/";
        private string txtFilePath = @"../search_info/Яндекс.Патенты/";
        private string fileName = "";

        Dictionary<string, string> formData;
        Dictionary<string, List<string>> forExcel;
        private SelectingFileName fileNameSelect;
        private SeleniumParsers parser;
        private ExcelFiles excel;
        private TextFiles txt;
        private FileExplorer fileExplorer;


        public YandexPatents()
        {
            InitializeComponent();

            cbDate.SelectedIndex = 0;
            chbApplication.Checked = true;
            chbPatent.Checked = true;

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
                    fileName = fileNameSelect.GetFileName();

                    parser = new SeleniumParsers();
                    forExcel = parser.ParseYandexPatents(formData);

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
            formData = new Dictionary<string, string>
            {
                { "Keys", tbKeys.Text },
                { "Document", tbDocument.Text },
                { "Application", tbApplication.Text },
                { "WhichDate", cbDate.SelectedItem.ToString() },
                { "DateStart", mtbStart.Text },
                { "DateEnd", mtbEnd.Text },
                { "Name", tbName.Text },
                { "Author", tbAuthor.Text },
                { "Patentee", tbPatentee.Text },
                { "isApplication", chbApplication.CheckState.ToString() },
                { "isPatent", chbPatent.CheckState.ToString() },
                { "DocAmount", tbDocAmount.Text }
            };
            ThreadPool.QueueUserWorkItem(ParseData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control el in tableLayoutPanelCenter.Controls)
            {
                if (el is KryptonTextBox)
                    el.Text = "";
            }

            cbDate.SelectedIndex = 0;

            mtbStart.Text = "";
            mtbEnd.Text = "";

            chbApplication.Checked = true;
            chbPatent.Checked = true;

            tbDocAmount.Text = "";
        }
    }
}
