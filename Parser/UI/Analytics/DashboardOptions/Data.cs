using System.Data;
using Parser.Models.main;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class Data : Form
    {
        DataSet dataSet;

        public Data(DataSet ds)
        {
            InitializeComponent();

            dataSet = ds;
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellURL = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (cellURL.Contains("http"))
            {
                var docNum = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                LinkNavigator navigator = new LinkNavigator();
                navigator.OpenLink(cellURL, docNum);
            }
        }
    }
}
