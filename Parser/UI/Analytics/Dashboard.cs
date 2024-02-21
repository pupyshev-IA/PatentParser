using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class Dashboard : Form
    {
        DataSet ds;

        public Dashboard(DataSet ds)
        {
            InitializeComponent();

            this.ds = new DataSet();
            this.ds = ds;

            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //);

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pnlBar.Height = btnTable.Height;
            pnlBar.Top = btnTable.Top + 6;
            pnlBar.Left = btnTable.Left;
            btnTable.BackColor = Color.FromArgb(70, 70, 70);

            lblName.Text = btnTable.Text;

            pnlDataLoader.Controls.Clear();
            InitialData initialData = new InitialData(ds) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlDataLoader.Controls.Add(initialData);
            initialData.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pnlBar.Height = btnTable.Height;
            pnlBar.Top = btnTable.Top + 6;
            pnlBar.Left = btnTable.Left;
            btnTable.BackColor = Color.FromArgb(70, 70, 70);

            lblName.Text = btnTable.Text;

            pnlDataLoader.Controls.Clear();
            InitialData initialData = new InitialData(ds) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlDataLoader.Controls.Add(initialData);
            initialData.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlBar.Height = btnInfo.Height;
            pnlBar.Top = btnInfo.Top + 6;
            pnlBar.Left = btnInfo.Left;
            btnInfo.BackColor = Color.FromArgb(70, 70, 70);

            lblName.Text = btnInfo.Text;
        }

        private void btnTable_Leave(object sender, EventArgs e)
        {
            btnTable.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnInfo_Leave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.FromArgb(40, 40, 40);
        }
    }
}
