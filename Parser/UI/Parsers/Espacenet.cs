using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Parser.Models.main;
using Parser.Models.Parsers;

namespace Parser.UI.Parsers
{
    public partial class Espacenet : Form
    {
        string path = @"../Результаты поиска/Espacenet/";
        string fileName;

        Dictionary<string, List<string>> forExcel;
        public ExcelFiles excel { get; }

        public Espacenet()
        {
            InitializeComponent();
            excel = new ExcelFiles();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (InternetConnection.CheckInternetConnection() == true)
            {
                if (File.Exists(path + fileName + ".xlsx"))
                {
                    MessageBox.Show("Файл с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!excel.CheckFileName(fileName))
                {
                    forExcel = EspacenetParser.ParseEspacenet(tbKeysName.Text, tbKeysText.Text, tbPublicationNum.Text, tbApplicationNum.Text,
                    tbDocNum.Text, tbDate.Text, tbApplicant.Text, tbInventor.Text, tbSRS.Text, tbMPK.Text, tbDocAmount.Text);

                    excel.CreateExcelFile(forExcel, path, fileName);
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенного имени файла. Оно также не должно включать в себя " +
                        "специальные символы '\\/:*?\"<>|'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Проверьте подключение к Интеренету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control el in tableLayoutPanelCenter.Controls)
            {
                if (el is KryptonTextBox)
                    el.Text = "";
            }
        }
    }
}
