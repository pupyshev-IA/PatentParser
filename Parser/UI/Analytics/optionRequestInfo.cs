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

namespace Parser.UI.Analytics
{
    public partial class optionRequestInfo : Form
    {
        private string directoryPath = @"../search_info/";
        private string filePath;
        private string fileName;

        public optionRequestInfo(string filePath)
        {
            InitializeComponent();

            this.filePath = filePath;
        }

        private void optionRequestInfo_Load(object sender, EventArgs e)
        {
            fileName = Path.GetFileName(filePath);
            fileName = fileName.Replace("xlsx", "txt");

            string folder = Directory.GetParent(filePath).Name;
            string fullPath = directoryPath + folder + "/" + fileName;

            GetSearchInfo(folder, fullPath);
            GetSearchParams(tlpRequestData, fullPath);
        }

        private void GetSearchInfo(string folder, string fullPath)
        {
            lblSearch.Text += folder;

            if (File.Exists(fullPath))
            {
                var lastLine = File.ReadLines(fullPath).Last();

                lblAmountValue.Text = lastLine.Split(':')[1];
            }
            else
            {
                lblAmountValue.Text = "Not found";
            }
        }

        private void GetSearchParams(TableLayoutPanel tableLayoutPanel, string fullPath)
        {
            if (File.Exists(fullPath))
            {
                string[] lines = File.ReadAllLines(fullPath);
                lines = lines.Take(lines.Count() - 1).ToArray();

                foreach (var line in lines)
                {
                    string[] separated = line.Split(':');
                    AddRow(tableLayoutPanel, separated[0], separated[1]);
                }
            }
            else
            {
                AddRow(tableLayoutPanel, "Not found", "Not found");
            }
        }

        private void AddRow(TableLayoutPanel tableLayoutPanel, string labelText, string value)
        {
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            Label keyLabel = new Label()
            {
                Text = labelText,
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.TopCenter
            };
            
            Label valueLabel = new Label()
            {
                Text = value,
                ForeColor = Color.FromArgb(27, 117, 208),
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.TopCenter
            };

            tableLayoutPanel.Controls.Add(keyLabel, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(valueLabel, 1, tableLayoutPanel.RowCount - 1);
        }
    }
}
