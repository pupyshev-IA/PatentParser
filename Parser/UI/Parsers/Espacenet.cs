using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parser.Models.main;
using Parser.Models.Parsers;

namespace Parser.UI.Parsers
{
    public partial class Espacenet : Form
    {
        Dictionary<string, List<string>> forExcel;
        public ExcelFiles excel { get; }

        public Espacenet()
        {
            InitializeComponent();
            excel = new ExcelFiles();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = InternetConnection.CheckInternetConnection(); 
            if (check == true)
            {
                forExcel = EspacenetParser.ParseEspacenet(tbKeysName.Text, tbKeysText.Text, tbPublicationNum.Text, tbApplicationNum.Text, 
                    tbDocNum.Text, tbDate.Text, tbApplicant.Text, tbInventor.Text, tbSRS.Text, tbMPK.Text, tbDocAmount.Text);

                excel.CreateExcelFile(forExcel);
            }
            else
            {
                MessageBox.Show("Проверьте подключение к Интеренету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control el in tlpAttributes.Controls)
            {
                if (el is TextBox)
                    el.Text = "";
            }
        }
    }
}
