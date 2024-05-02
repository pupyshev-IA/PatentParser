using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Parser.UI.DialogForm;
using Parser.UI.Parsers;

namespace Parser.UI.main
{
    public partial class ParserContainer : Form
    {
        private static ParserContainer instance = null;
        public static ParserContainer getInstance()
        {
            if (instance == null)
                instance = new ParserContainer();
            return instance;
        }


        protected ParserContainer()
        {
            InitializeComponent();

            tabControl_Parsers.TabPages[tabControl_Parsers.TabCount - 1].Text = "";
            tabControl_Parsers.Padding = new Point(18, 4);
            tabControl_Parsers.DrawMode = TabDrawMode.OwnerDrawFixed;

            tabControl_Parsers.HandleCreated += tabControl_Parsers_HandleCreated;
        }


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;

        private void tabControl_Parsers_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(tabControl_Parsers.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }


        private void tabControl_Parsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = tabControl_Parsers.TabPages[e.Index];
            var tabRect = tabControl_Parsers.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);


            //Set Tabcontrol border
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(25, 25, 25), 8);
            g.DrawRectangle(p, tabPage.Bounds);

            //Set Border header
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), e.Bounds);
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);


            if (e.Index == tabControl_Parsers.TabCount - 1)
            {
                var addImage = imageList_icons.Images[0];
                e.Graphics.DrawImage(addImage, tabRect.Left + (tabRect.Width - addImage.Width) / 2, tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = imageList_icon.Images[0];
                e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top /*+ (tabRect.Height - closeImage.Height) / 2*/);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }

        private void tabControl_Parsers_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = tabControl_Parsers.TabCount - 1;
            if (tabControl_Parsers.GetTabRect(lastIndex).Contains(e.Location))
            {
                SelectingNewTab newTab = new SelectingNewTab();
                newTab.ShowDialog();
            }
            else
            {
                for (var i = 0; i < tabControl_Parsers.TabPages.Count; i++)
                {
                    var tabRect = tabControl_Parsers.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = imageList_icon.Images[0];
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top /*+ (tabRect.Height - closeImage.Height) / 2*/,
                        closeImage.Width,
                        closeImage.Height);

                    if (imageRect.Contains(e.Location))
                    {
                        tabControl_Parsers.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl_Parsers_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == tabControl_Parsers.TabCount - 1)
                e.Cancel = true;
        }

        private void makeTab(int lastIndex, string tabName)
        {
            tabControl_Parsers.TabPages.Insert(lastIndex, tabName);
            tabControl_Parsers.SelectedIndex = lastIndex;
            tabControl_Parsers.TabPages[lastIndex].UseVisualStyleBackColor = true;
        }

        public void cbCheckedItems(List<string> cbChecked)
        {
            var lastIndex = tabControl_Parsers.TabCount - 1;
            foreach (string el in cbChecked)
            {
                switch (el)
                {
                    case "ФИПС":
                        FIPS fips = new FIPS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        makeTab(lastIndex, el);
                        tabControl_Parsers.TabPages[lastIndex].Controls.Add(fips);
                        fips.Show();
                        break;

                    case "Яндекс.Патенты":
                        YandexPatents yandexPatents = new YandexPatents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        makeTab(lastIndex, el);
                        tabControl_Parsers.TabPages[lastIndex].Controls.Add(yandexPatents);
                        yandexPatents.Show();
                        break;

                    case "Espacenet":
                        Espacenet espacenet = new Espacenet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        makeTab(lastIndex, el);
                        tabControl_Parsers.TabPages[lastIndex].Controls.Add(espacenet);
                        espacenet.Show();
                        break;

                    case "WIPO":
                        WIPO wipo = new WIPO() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        makeTab(lastIndex, el);
                        tabControl_Parsers.TabPages[lastIndex].Controls.Add(wipo);
                        wipo.Show();
                        break;

                    case "Роспатент":
                        Rospatent rospatent = new Rospatent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        makeTab(lastIndex, el);
                        tabControl_Parsers.TabPages[lastIndex].Controls.Add(rospatent);
                        rospatent.Show();
                        break;
                }
            }
        }

        private void btnNewParser_Click(object sender, EventArgs e)
        {
            SelectingNewTab newTab = new SelectingNewTab();
            newTab.ShowDialog();
        }
    }
}
