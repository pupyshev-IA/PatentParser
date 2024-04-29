using System;
using System.Drawing;
using System.Windows.Forms;
using Parser.Models.main;
using Parser.UI.UserControls;
using Parser.Models.Analytics.ChatBots.GigaChat;
using Parser.Models.Analytics.ChatBots.YandexGPT;

namespace Parser.UI.Analytics.DashboardOptions
{
    public partial class ChatBot : Form
    {
        GigaChat gigaChat;
        YandexGPT yandexGPT;

        public ChatBot()
        {
            InitializeComponent();

            gigaChat = new GigaChat();
            yandexGPT = new YandexGPT();
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

        private void pnlYandexGPTHeader_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, pnlYandexGPTHeader.Width, pnlYandexGPTHeader.Height, 30, 30);
            pnlYandexGPTHeader.Region = Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void pnlYandexGPTText_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, pnlYandexGPTText.Width, pnlYandexGPTText.Height, 30, 30);
            pnlYandexGPTText.Region = Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private async void btnGigaChatSend_Click(object sender, EventArgs e)
        {
            AddGigaChatMessage(tbGigaChatRequest.Text);

            var answer = await gigaChat.AskQuestion(tbGigaChatRequest.Text);
            tbGigaChatRequest.Text = "";
            tbGigaChatRequest.Focus();

            AddGigaChatMessage(answer, isAnswer: true);
        }

        private async void btnYandexGPTSend_Click(object sender, EventArgs e)
        {
            AddYandexGPTMessage(tbYandexGPTRequest.Text);

            var answer = await yandexGPT.AskQuestion(tbYandexGPTRequest.Text);
            tbYandexGPTRequest.Text = "";
            tbYandexGPTRequest.Focus();

            AddYandexGPTMessage(answer, isAnswer: true);
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

        private void AddYandexGPTMessage(string text, bool isAnswer = false)
        {
            if (isAnswer)
            {
                var message = new Incoming(text);
                message.Dock = DockStyle.Top;
                pnlYandexGPTText.Controls.Add(message);
                message.BringToFront();
                message.Show();
            }
            else
            {
                var message = new Outcoming(text);
                message.Dock = DockStyle.Top;
                pnlYandexGPTText.Controls.Add(message);
                message.BringToFront();
                message.Show();
            }
        }
    }
}
