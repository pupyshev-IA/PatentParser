using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class Dashboard : Form
    {
        DataSet dataSet;
        string filePath;

        private optionRequestInfo requestInfo;
        private optionDataView dataView;

        public Dashboard(DataSet ds, string filePath)
        {
            InitializeComponent();

            dataSet = new DataSet();
            dataSet = ds;
            this.filePath = filePath;

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

        private void OptionChanged()
        {
            foreach (Control el in panelNavigation.Controls)
                if (el is Button)
                    el.BackColor = Color.FromArgb(40, 40, 40);

            requestInfo.Hide();
            dataView.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pnlBar.Height = btnInfo.Height;
            pnlBar.Top = btnInfo.Top + 6;
            pnlBar.Left = btnInfo.Left;
            btnInfo.BackColor = Color.FromArgb(70, 70, 70);

            lblName.Text = btnInfo.Text;

            requestInfo = new optionRequestInfo(filePath) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(requestInfo);
            requestInfo.Show();

            dataView = new optionDataView(dataSet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(dataView);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnInfo.Text;
            requestInfo.Show();

            pnlBar.Top = btnInfo.Top + 6;
            btnInfo.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnTable.Text;
            dataView.Show();

            pnlBar.Top = btnTable.Top + 6;
            btnTable.BackColor = Color.FromArgb(70, 70, 70);
        }
    }
}
