using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Parser.UI.Analytics
{
    public partial class Dashboard : Form
    {
        DataSet dataSet;
        string filePath;

        private RequestInfo requestInfo;
        private Data dataView;

        public Dashboard(DataSet ds, string filePath)
        {
            InitializeComponent();

            dataSet = new DataSet();
            dataSet = ds;
            this.filePath = filePath;
        }

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

            requestInfo = new RequestInfo(filePath, dataSet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(requestInfo);
            requestInfo.Show();

            dataView = new Data(dataSet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
