using System;
using System.Drawing;
using System.Windows.Forms;
using Parser.Models.main;
using Parser.UI.UserControls;
using Parser.Models.Analytics.ChatBots.GigaChat;

namespace Parser.UI.Analytics.DashboardOptions
{
    public partial class ChatBot : Form
    {
        GigaChat gigaChat;

        public ChatBot()
        {
            InitializeComponent();

            gigaChat = new GigaChat();
        }

        private void pnlGigaChatHeader_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, pnlGigaChatHeader.Width, pnlGigaChatHeader.Height, 30, 30);
            pnlGigaChatHeader.Region = Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void pnlGigaChatText_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, pnlGigaChatText.Width, pnlGigaChatText.Height, 30, 30);
            pnlGigaChatText.Region = Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private async void btnGigaChatSend_Click(object sender, EventArgs e)
        {
            AddGigaChatMessage(tbRequest.Text);

            var answer = await gigaChat.AskQuestion(tbRequest.Text);
            tbRequest.Text = "";
            tbRequest.Focus();

            AddGigaChatMessage(answer, isAnswer: true);
        }

        private void AddGigaChatMessage(string text, bool isAnswer = false)
        {
            if (isAnswer)
            {
                var message = new Incoming(text);
                message.Dock = DockStyle.Top;
                pnlGigaChatText.Controls.Add(message);
                message.BringToFront();
                message.Show();
            }
            else
            {
                var message = new Outcoming(text);
                message.Dock = DockStyle.Top;
                pnlGigaChatText.Controls.Add(message);
                message.BringToFront();
                message.Show();
            }
        }
    }
}
