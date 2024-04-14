using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Parser.UI.main;

namespace Parser.UI.DialogForm
{
    public partial class SelectingNewTab : Form
    {
        ParserContainer parserContainer = ParserContainer.getInstance();

        public SelectingNewTab()
        {
            InitializeComponent();

            clbParsers.SelectedIndex = 0;
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

        private void clbParsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedParser = clbParsers.SelectedItem.ToString();
            var info = GetPatentParsersInfo(selectedParser);

            if (info != null)
                lblNote.Text = info;
        }

        private string GetPatentParsersInfo(string parser)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Parser.res.parser_info.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    return "Not found";

                using (StreamReader reader = new StreamReader(stream))
                {
                    string text = reader.ReadToEnd();

                    string pattern = $@"{parser}: /([^/]+?)/";
                    Match match = Regex.Match(text, pattern);
                    string info = match.Groups[0].Value.Replace($"{parser}: /", "").Replace("/", "");

                    return info;
                }
            }
        }

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
