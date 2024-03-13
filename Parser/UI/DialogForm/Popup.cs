using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parser.UI.DialogForm
{
    public partial class Popup : Form
    {
        Point location;
        private Timer timer;

        public Popup(string text, Point location)
        {
            InitializeComponent();

            this.location = location;
            label.Text = text;
        }

        /*_________________________________________________________________________________________*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*_________________________________________________________________________________________*/

        private void Popup_Load(object sender, EventArgs e)
        {
            Location = location;
            Size = new Size(label.Width, label.Height);

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Close();
            Dispose();
        }
    }
}
