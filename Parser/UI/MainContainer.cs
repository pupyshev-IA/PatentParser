using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Parser.UI
{
    public partial class MainContainer : Form //KryptonForm
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        private void MainContainer_Load(object sender, EventArgs e)
        {
            LoadFileExplorer();

            /*ПРИ ВОССТАНОВЛЕНИИ СОСТОЯНИЯ ПРИ ПОВТОРНОМ ЗАПУСКЕ ДОБАВИТЬ УСЛОВИЕ: результат диалогового окна (да) - > выполнить*/
            LoadParserContainer();
            btnNewParser.Hide();
            /*ФУНКЦИЯ ПЕРЕДАЮЩАЯ СПИСОК В МЕТОД КЛАССА ParserContainer*/
        }


        private void LoadFileExplorer()
        {
            FileExplorer fileExplorer = new FileExplorer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            splitContainer_out.Panel1.Controls.Add(fileExplorer);
            fileExplorer.Show();
        }

        private void LoadParserContainer()
        {
            ParserContainer parserContainer = ParserContainer.getInstance();
            parserContainer.Dock = DockStyle.Fill;
            parserContainer.TopLevel = false;
            parserContainer.TopMost = true;
            splitContainer_in.Panel1.Controls.Add(parserContainer);
            parserContainer.Show();
        }

        private void btnNewParser_Click(object sender, EventArgs e)
        {
            LoadParserContainer();

            btnNewParser.Hide();
        }
    }
}
