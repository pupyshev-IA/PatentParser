using System;
using System.Data;
using System.Windows.Forms;

namespace Parser.UI.DialogForm
{
    public partial class DataFilter : Form
    {
        DataTable table;
        DataView filteredTable;
        public DataView FilteredTable { get { return filteredTable; } }

        public DataFilter(DataTable table)
        {
            InitializeComponent();
            this.table = table;
        }

        /*_________________________________________________________________________________________*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void DataFilter_Load(object sender, EventArgs e)
        {
            if (cbHeaders.Items.Count > 0)
                return;

            foreach (DataColumn column in table.Columns)
                if (column.ColumnName != "Ссылка")
                    cbHeaders.Items.Add(column.ColumnName);

            UpdateButtons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbHeaders.SelectedIndex == -1)
                return;

            tbSearch.Text += "[" + cbHeaders.SelectedItem.ToString() + "] ";
            tbSearch.SelectionStart = tbSearch.Text.Length;
            tbSearch.Focus();
            UpdateButtons();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            tbSearch.SelectionStart = tbSearch.Text.Length;
            UpdateButtons();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            tbSearch.Text += "AND ";
            tbSearch.SelectionStart = tbSearch.Text.Length;
            tbSearch.Focus();
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            tbSearch.Text += "OR ";
            tbSearch.SelectionStart = tbSearch.Text.Length;
            tbSearch.Focus();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            tbSearch.Text += "LIKE '' ";
            tbSearch.SelectionStart = tbSearch.Text.Length - 2;
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                filteredTable = new DataView(table);
                filteredTable.RowFilter = tbSearch.Text;

                Hide();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода запроса:\n" +
                    "Убедитесь, что операторы соответсвуют типам данных.\n" +
                    "Также все значения должны быть заключены в кавычки ' '.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateButtons()
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                btnAnd.Enabled = false;
                btnOr.Enabled = false;
                btnLike.Enabled = false;
            }
            else
            {
                btnAnd.Enabled = true;
                btnOr.Enabled = true;
                btnLike.Enabled = true;
            }
        }
    }
}
