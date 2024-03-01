using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using Parser.Models.Analytics;

namespace Parser.UI.Analytics
{
    public partial class optionRequestInfo : Form
    {
        private string directoryPath = @"../search_info/";
        private string filePath;
        private string fileName;
        private DataSet dataSet;

        LiveChart charts;

        public optionRequestInfo(string filePath, DataSet dataSet)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.dataSet = dataSet;

            charts = new LiveChart();
        }

        private void SetPieChart(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                string[] lines = File.ReadAllLines(fullPath);
                var fullAmount = lines[lines.Length - 1].Split(':')[1].Replace(",", "");
                var parsedAmount = lines[lines.Length - 2].Split(':')[1];

                charts.CreatePieChart(solidGauge_docAmount, int.Parse(fullAmount), int.Parse(parsedAmount));
            }
        }

        private void SetColumnChart(string funcType)
        {
            switch (funcType)
            {
                case "Espacenet":
                    List<int> lblEspacenet = new List<int>();
                    lblEspacenet = dataSet.Tables[0].AsEnumerable()
                        .Select(row => row.Field<DateTime>("Дата приоритета").Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();

                    List<int> valueEspacenet = new List<int>();
                    foreach (var el in lblEspacenet)
                    {
                        var val = dataSet.Tables[0].AsEnumerable()
                            .Select(row => row.Field<DateTime>("Дата приоритета").Year)
                            .Count(x => x == el);

                        valueEspacenet.Add(val);
                    }

                    charts.CreateColumnChart(cartesianChart_dates, lblEspacenet.ConvertAll(i => i.ToString()), valueEspacenet);
                    break;

                case "ФИПС":
                    List<int> lblFips = new List<int>();
                    lblFips = dataSet.Tables[0].AsEnumerable()
                        .Select(row => row.Field<string>("Дата публикации"))
                        .Select(date => DateTime.Parse(date).Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();

                    List<int> valueFips = new List<int>();
                    foreach (var el in lblFips)
                    {
                        var val = dataSet.Tables[0].AsEnumerable()
                            .Select(row => row.Field<string>("Дата публикации"))
                            .Select(date => DateTime.Parse(date).Year)
                            .Count(x => x == el);

                        valueFips.Add(val);
                    }

                    charts.CreateColumnChart(cartesianChart_dates, lblFips.ConvertAll(i => i.ToString()), valueFips);
                    break;

                case "Яндекс.Патенты":
                    List<int> lblYandexPatents = new List<int>();
                    lblYandexPatents = dataSet.Tables[0].AsEnumerable()
                        .Select(row => row.Field<string>("Публикация"))
                        .Select(date => DateTime.Parse(date).Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();

                    List<int> valueYandexPatents = new List<int>();
                    foreach (var el in lblYandexPatents)
                    {
                        var val = dataSet.Tables[0].AsEnumerable()
                            .Select(row => row.Field<string>("Публикация"))
                            .Select(date => DateTime.Parse(date).Year)
                            .Count(x => x == el);

                        valueYandexPatents.Add(val);
                    }

                    charts.CreateColumnChart(cartesianChart_dates, lblYandexPatents.ConvertAll(i => i.ToString()), valueYandexPatents);
                    break;

                case "WIPO":
                    break;
            }
        }

        private void optionRequestInfo_Load(object sender, EventArgs e)
        {
            fileName = Path.GetFileName(filePath);
            fileName = fileName.Replace("xlsx", "txt");

            string folder = Directory.GetParent(filePath).Name;
            string fullPath = directoryPath + folder + "/" + fileName;

            GetSearchInfo(folder, fullPath);
            GetSearchParams(tlpRequestData, fullPath);

            SetPieChart(fullPath);
            SetColumnChart(folder);
        }

        private void GetSearchInfo(string folder, string fullPath)
        {
            lblSearch.Text += folder;

            if (File.Exists(fullPath))
            {
                var lastLine = File.ReadLines(fullPath).Last();

                lblFullAmountValue.Text = lastLine.Split(':')[1];
            }
            else
            {
                lblFullAmountValue.Text = "Not found";
            }
        }

        private void GetSearchParams(TableLayoutPanel tableLayoutPanel, string fullPath)
        {
            if (File.Exists(fullPath))
            {
                string[] lines = File.ReadAllLines(fullPath);
                lines = lines.Take(lines.Count() - 2).ToArray();

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
