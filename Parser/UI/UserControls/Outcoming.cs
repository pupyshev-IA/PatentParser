using System;
using System.Drawing;
using System.Windows.Forms;
using Parser.Models.main;

namespace Parser.UI.UserControls
{
    public partial class Outcoming : UserControl
    {
        private string messageText;

        public Outcoming(string text)
        {
            InitializeComponent();
            messageText = text;
        }

        private void Outcoming_Load(object sender, EventArgs e)
        {
            lblMessage.Text = messageText;
            Size = new Size(Width, lblMessage.Height + 30);
        }

        private void pnlMessage_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, pnlMessage.Width, pnlMessage.Height, 30, 30);
            pnlMessage.Region = Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }
    }
}
