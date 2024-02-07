using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser.UI.Parsers;

namespace Parser.UI
{
    public partial class SelectingNewTab : Form
    {
        ParserContainer parserContainer = ParserContainer.getInstance();

        public SelectingNewTab()
        {
            InitializeComponent();
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
    }
}
