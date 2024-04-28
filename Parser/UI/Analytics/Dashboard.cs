using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Parser.UI.Analytics.DashboardOptions;

namespace Parser.UI.Analytics
{
    public partial class Dashboard : Form
    {
        DataSet dataSet;
        string filePath;

        private RequestInfo requestInfo;
        private Data data;
        private PatentInfo patentInfo;
        private ChatBot chatBot;

        public Dashboard(DataSet ds, string filePath)
        {
            InitializeComponent();

            dataSet = ds;
            this.filePath = filePath;
        }

        private void OptionChanged()
        {
            foreach (Control el in panelNavigation.Controls)
                if (el is Button)
                    el.BackColor = Color.FromArgb(40, 40, 40);

            requestInfo.Hide();
            data.Hide();
            patentInfo.Hide();
            chatBot.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pnlBar.Height = btnRequestInfo.Height;
            pnlBar.Top = btnRequestInfo.Top + 6;
            pnlBar.Left = btnRequestInfo.Left;
            btnRequestInfo.BackColor = Color.FromArgb(70, 70, 70);

            lblName.Text = btnRequestInfo.Text;

            requestInfo = new RequestInfo(filePath, dataSet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(requestInfo);
            requestInfo.Show();

            data = new Data(this, dataSet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(data);

            patentInfo = new PatentInfo(requestInfo) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(patentInfo);

            chatBot = new ChatBot() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlFormLoader.Controls.Add(chatBot);
        }

        private void btnRequestInfo_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnRequestInfo.Text;
            requestInfo.Show();

            pnlBar.Top = btnRequestInfo.Top + 6;
            btnRequestInfo.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnTable.Text;
            data.Show();

            pnlBar.Top = btnTable.Top + 6;
            btnTable.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnPatentInfo_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnPatentInfo.Text;

            patentInfo.RowIndex = data.SelectedIndex;
            patentInfo.Link = data.SelectedLink;
            patentInfo.DocNum = data.SelectedDocNum;

            patentInfo.Show();

            pnlBar.Top = btnPatentInfo.Top + 6;
            btnPatentInfo.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            OptionChanged();
            lblName.Text = btnChatBot.Text;
            chatBot.Show();

            pnlBar.Top = btnChatBot.Top + 6;
            btnChatBot.BackColor = Color.FromArgb(70, 70, 70);
        }

        public void ClickPatentInfoButton()
        {
            btnPatentInfo.PerformClick();
        }
    }
}
