using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Threading;
using System.Diagnostics;

namespace Parser.UI
{
    public partial class FileExplorer : Form
    {
        public TreeNode rootNode;
        string path = @"../Результаты поиска/";

        public FileExplorer()
        {
            InitializeComponent();
            updateExplorer();
        }

        private void PopulateTreeView()
        {
            DirectoryInfo info = new DirectoryInfo(path);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.ImageKey = "folder";
                GetDirectories(info.GetDirectories(), rootNode);
                treeView_ExcelFiles.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void GetAllExcelFiles(string path, TreeNode currentNode)
        {
            TreeNode excelNode;

            string[] folder = Directory.GetFiles(path + currentNode.Tag, "*" + textBox_Search.Text + "*xlsx");

            foreach (string file in folder)
            {
                excelNode = new TreeNode(Path.GetFileNameWithoutExtension(file), 1, 1);
                excelNode.ImageKey = "excel";
                currentNode.Nodes.Add(excelNode);
            }
        }

        private void updateExplorer()
        {
            PopulateTreeView();

            foreach (TreeNode curNode in rootNode.Nodes)
                GetAllExcelFiles(path, curNode);

            treeView_ExcelFiles.ExpandAll();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Search.Text))
            {
                pictureBox_Clear.Image = imageList_formIcons.Images[0];
                treeView_ExcelFiles.Nodes.Clear();

                updateExplorer();

                return;
            }

            pictureBox_Clear.Image = imageList_formIcons.Images[1];
            foreach (TreeNode node in treeView_ExcelFiles.Nodes)
                node.Nodes.Clear();

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(path)
                                                          .Select(d => new DirectoryInfo(d).Name));

            foreach (string dir in dirs)
            {
                try
                {
                    var _excelFiles = Directory.EnumerateFiles(path + dir + @"/", "*" + textBox_Search.Text + "*.xlsx");

                    if (_excelFiles.Any())
                    {
                        TreeNode aNode;
                        aNode = new TreeNode(dir, 0, 0);
                        aNode.Tag = dir;
                        aNode.ImageKey = "folder";
                        rootNode.Nodes.Add(aNode);

                        GetAllExcelFiles(path, aNode);
                        treeView_ExcelFiles.ExpandAll();
                    }
                }
                catch 
                {
                    continue;
                }
            }
        }

        private void treeView_ExcelFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageKey == "folder")
                return;

            var _path = Path.Combine(Directory.GetCurrentDirectory(), @"../Результаты поиска/" + e.Node.Parent.Text + @"/" + e.Node.Text + ".xlsx");

            if (File.Exists(_path))
                Process.Start(_path);
            else
            {
                DialogResult _res = MessageBox.Show("Файл был удален или перемещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (_res == DialogResult.OK)
                {
                    treeView_ExcelFiles.Nodes.Clear();
                    updateExplorer();
                }
            }
        }

        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear();
            treeView_ExcelFiles.Nodes.Clear();

            updateExplorer();
            pictureBox_Clear.Image = imageList_formIcons.Images[0];
        }
    }
}


//var excelApp = new Excel.Application();
//excelApp.Visible = true;
//Excel.Workbook wbv = excelApp.Workbooks.Open(path);

//wbv.Close();
//Marshal.ReleaseComObject(wbv);

//excelApp.Quit();
//Marshal.ReleaseComObject(excelApp);