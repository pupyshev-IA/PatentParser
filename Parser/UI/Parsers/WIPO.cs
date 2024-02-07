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
    public partial class WIPO : Form
    {
        public WIPO()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control el in tlpAttributes.Controls)
            {
                if (el is TextBox)
                    el.Text = "";
            }
        }
    }
}
