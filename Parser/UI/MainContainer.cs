using System;
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

            LoadDataView();
        }


        private void LoadFileExplorer()
        {
            FileExplorer fileExplorer = FileExplorer.getInstance();
            fileExplorer.Dock = DockStyle.Fill;
            fileExplorer.TopLevel = false;
            fileExplorer.TopMost = true;
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

        private void LoadDataView()
        {
            DataView dataView = DataView.getInstance();
            dataView.Dock = DockStyle.Fill;
            dataView.TopLevel = false;
            dataView.TopMost = true;
            splitContainer_in.Panel2.Controls.Add(dataView);
            dataView.Show();
        }
    }
}
