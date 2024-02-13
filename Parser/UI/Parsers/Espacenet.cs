using System;
using System.Collections.Generic;
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

        Dictionary<string, List<string>> forExcel;
        private EspacenetParser parser;
        private ExcelFiles excel { get; }
        private SelectingFileName fileNameSelect;

        public Espacenet()
        {
            InitializeComponent();
            excel = new ExcelFiles();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (InternetConnection.IsInternetConnected())
            {
                fileNameSelect = new SelectingFileName(filePath);
                fileNameSelect.ShowDialog();

                if (fileNameSelect.IsAcceptStatus())
                {
                    fileName = fileNameSelect.GetFileName();

                    parser = new EspacenetParser();
                    forExcel = parser.ParseEspacenet(tbKeysName.Text, tbKeysText.Text, tbPublicationNum.Text, tbApplicationNum.Text,
                        tbDocNum.Text, tbDate.Text, tbApplicant.Text, tbInventor.Text, tbSRS.Text, tbMPK.Text, tbDocAmount.Text);

                    excel.CreateExcelFile(forExcel, filePath, fileName);
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
