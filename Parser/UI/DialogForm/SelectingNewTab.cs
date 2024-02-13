using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parser.UI
{
    public partial class SelectingNewTab : Form
    {
        ParserContainer parserContainer = ParserContainer.getInstance();

        public SelectingNewTab()
        {
            InitializeComponent();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<string> allItems;

            if (clbParsers.CheckedIndices.Count != 0)
            {
                allItems = clbParsers.CheckedItems.OfType<String>().ToList();
                parserContainer.cbCheckedItems(allItems);

                Close();
            }
            else
                MessageBox.Show("Необходимо выбрать хотя бы один пункт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
