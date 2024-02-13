using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Parser.UI
{
    public partial class SelectingFileName : Form
    {
        private bool isAcceptStatus;
        private string fileName;
        private string filePath;

        string specialChar = "\\|/?»:«*\"<>";

        public SelectingFileName(string path)
        {
            InitializeComponent();

            filePath = path;
            isAcceptStatus = false;

            labelUnderNote.Text = "Укажите имя файла.";
            labelUnderNote.ForeColor = Color.White;

            textBox_fileName.Select();
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

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            if (IsFileNameValid(textBox_fileName.Text))
            {
                fileName = textBox_fileName.Text;
                isAcceptStatus = true;

                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsFileNameValid(string fileName)
        {
            if (File.Exists(filePath + fileName + ".xlsx"))
            {
                labelUnderNote.Text = "Файл с таким именем уже существует.";
                labelUnderNote.ForeColor = Color.Red;
                textBox_fileName.SelectAll();
                textBox_fileName.Focus();

                return false;
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var item in specialChar)
                {
                    if (fileName.Contains(item))
                    {
                        labelUnderNote.Text = "Проверьте правильность введенного имени файла. \nОно также не должно включать " +
                            "в себя специальные символы: \\\\/:*?\\\"<>|";
                        labelUnderNote.ForeColor = Color.Red;
                        textBox_fileName.SelectAll();
                        textBox_fileName.Focus();

                        return false;
                    }
                }
                return true;
            }
            else
            {
                labelUnderNote.Text = "Необходимо заполнить поле.";
                labelUnderNote.ForeColor = Color.Red;
                textBox_fileName.Focus();

                return false;
            }
        }

        public string GetFileName()
        {
            return fileName;
        }

        public bool IsAcceptStatus()
        {
            return isAcceptStatus;
        }
    }
}
