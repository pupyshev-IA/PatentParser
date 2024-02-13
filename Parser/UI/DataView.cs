using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Parser.UI
{
    public partial class DataView : Form
    {
        private string filePath;
        OleDbConnection connection;
        DataSet dataSet;
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

        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;

            ShowDataTable();
        }

        private void ShowDataTable()
        {
            var query = "SELECT * FROM [Лист1$]";
            dataSet = new DataSet();

            connection = new OleDbConnection($"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '{filePath}'; Extended Properties = Excel 8.0;");
            connection.Open();

            adapter = new OleDbDataAdapter(query, connection);
            adapter.TableMappings.Add("Table", "TestTable");
            adapter.Fill(dataSet);

            connection.Close();
            dataGridView_excel.DataSource = dataSet.Tables[0];
        }
    }
}
