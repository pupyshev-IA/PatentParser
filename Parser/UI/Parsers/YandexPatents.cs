using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser.UI.Parsers
{
    public partial class YandexPatents : Form
    {
        public YandexPatents()
        {
            InitializeComponent();
        }

        private void YandexPatents_Load(object sender, EventArgs e)
        {
            cbDate.SelectedIndex = 0;

            chbApplication.Checked = true;
            chbPatent.Checked = true;
        }
    }
}
