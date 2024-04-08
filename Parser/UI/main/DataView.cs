using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Parser.Models.main;
using Parser.UI.Analytics;

namespace Parser.UI
{
    public partial class DataView : Form
    {
        private string filePath;
        private int page = 0;
        DataSet dataSet, dividedDataSet;
        OleDbConnection connection;
        OleDbDataAdapter adapter;

        private static DataView instance = null;
        public static DataView getInstance()
        {
            if (instance == null)
                instance = new DataView();
            return instance;
        }


        protected DataView()
        {
            InitializeComponent();
        }

        public void ChangeDataView(string path)
        {
            filePath = path;

            ExtractDataTable(filePath);
            dataGridView_excel.DataSource = DivideDataSet(dataSet).Tables[0];

            lblPage.Visible = true;
            btnLeft.Visible = true;
            btnRight.Visible = true;
            page = 0;
            UpdatePaging();
        }

        private void ExtractDataTable(string filePath)
        {
            var query = "SELECT * FROM [Лист1$]";
            dataSet = new DataSet();

            connection = new OleDbConnection($"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '{filePath}'; Extended Properties = Excel 8.0;");
            connection.Open();

            adapter = new OleDbDataAdapter(query, connection);
            adapter.Fill(dataSet);

            connection.Close();
        }

        private DataSet DivideDataSet(DataSet dataSet)
        {
            dividedDataSet = new DataSet();
            DataTable dt = new DataTable();
            int rowCount = 0;
            int tableCount = 1;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (rowCount == 0)
                {
                    dt = new DataTable();
                    dt = dataSet.Tables[0].Clone();
                    dt.TableName = $"Table {tableCount++}";
                }

                dt.ImportRow(row);

                if (++rowCount == 35)
                {
                    dividedDataSet.Tables.Add(dt);
                    dt = null;
                    rowCount = 0;
                }
            }

            if (dt != null && dt.Rows.Count > 0)
                dividedDataSet.Tables.Add(dt);

            return dividedDataSet;
        }

        private void ShowCurrentTable()
        {
            dataGridView_excel.DataSource = dividedDataSet.Tables[page];
        }

        private void UpdatePaging()
        {
            btnLeft.Enabled = page > 0;

            btnRight.Enabled = page < dividedDataSet.Tables.Count - 1;

            lblPage.Text = $"Страница: {page + 1} (из {dividedDataSet.Tables.Count})";
        }

        private void dataGridView_excel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellURL = dataGridView_excel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (cellURL.Contains("http"))
            {
                var docNum = dataGridView_excel.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                LinkNavigator navigator = new LinkNavigator();
                navigator.OpenLink(cellURL, docNum);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (page == 0)
                return;

            page--;
            ShowCurrentTable();
            UpdatePaging();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (page == dividedDataSet.Tables.Count)
                return;

            page++;
            ShowCurrentTable();
            UpdatePaging();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            if (dataSet != null)
            {
                Dashboard dashboard = new Dashboard(dataSet, filePath);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать исходный файл для анализа.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
