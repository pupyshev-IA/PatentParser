using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using Parser.Models.Analytics;
using Parser.Models.Analytics.Clustering;
using Parser.UI.DialogForm;

namespace Parser.UI.Analytics.DashboardOptions
{
    public partial class RequestInfo : Form
    {
        private string directoryPath = @"../search_info/";
        private string filePath;
        private DataSet dataSet;
        private List<float[]> scores;
        public List<float[]> Scores { get => scores; }

        LiveChart charts;
        List<string> patentTitles;
        Dictionary<List<double>, string> resultAxis;
        Popup popup;

        public RequestInfo(string filePath, DataSet dataSet)
        {
            InitializeComponent();

            this.filePath = filePath;
            this.dataSet = dataSet;

            charts = new LiveChart();
        }

        private void optionRequestInfo_Load(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(filePath);
            fileName = fileName.Replace("xlsx", "txt");

            string folder = Directory.GetParent(filePath).Name;
            string fullPath = directoryPath + folder + "/" + fileName;

            GetSearchInfo(folder, fullPath);
            GetSearchParams(tlpRequestData, fullPath);

            SetSolidGauge(fullPath);
            SetColumnChart(folder);
            SetScatterPlot();
        }

        private void SetSolidGauge(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                string[] lines = File.ReadAllLines(fullPath);
                var fullAmount = lines[lines.Length - 1].Split(':')[1].Replace(",", "");
                var parsedAmount = lines[lines.Length - 2].Split(':')[1];

                charts.CreateSolidGauge(solidGauge_docAmount, int.Parse(fullAmount), int.Parse(parsedAmount));
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

                    charts.CreateColumnChartForDates(cartesianChart_dates, lblEspacenet.ConvertAll(i => i.ToString()), valueEspacenet);
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

                    charts.CreateColumnChartForDates(cartesianChart_dates, lblFips.ConvertAll(i => i.ToString()), valueFips);
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

                    charts.CreateColumnChartForDates(cartesianChart_dates, lblYandexPatents.ConvertAll(i => i.ToString()), valueYandexPatents);
                    break;

                case "WIPO":
                    List<int> lblWipo = new List<int>();
                    lblWipo = dataSet.Tables[0].AsEnumerable()
                        .Select(row => row.Field<string>("Дата публикации"))
                        .Select(date => DateTime.Parse(date).Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();

                    List<int> valueWipo = new List<int>();
                    foreach (var el in lblWipo)
                    {
                        var val = dataSet.Tables[0].AsEnumerable()
                            .Select(row => row.Field<string>("Дата публикации"))
                            .Select(date => DateTime.Parse(date).Year)
                            .Count(x => x == el);

                        valueWipo.Add(val);
                    }

                    charts.CreateColumnChartForDates(cartesianChart_dates, lblWipo.ConvertAll(i => i.ToString()), valueWipo);
                    break;

                case "Роспатент":
                    List<int> lblRospatent = new List<int>();
                    lblRospatent = dataSet.Tables[0].AsEnumerable()
                        .Select(row => row.Field<string>("Дата публикации"))
                        .Select(date => DateTime.Parse(date).Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();

                    List<int> valueRospatent = new List<int>();
                    foreach (var el in lblRospatent)
                    {
                        var val = dataSet.Tables[0].AsEnumerable()
                            .Select(row => row.Field<string>("Дата публикации"))
                            .Select(date => DateTime.Parse(date).Year)
                            .Count(x => x == el);

                        valueRospatent.Add(val);
                    }

                    charts.CreateColumnChartForDates(cartesianChart_dates, lblRospatent.ConvertAll(i => i.ToString()), valueRospatent);
                    break;
            }
        }

        private void SetScatterPlot()
        {
            patentTitles = new List<string>();
            patentTitles = dataSet.Tables[0].AsEnumerable()
                .Select(row => row.Field<String>("Название"))
                .ToList();

            DataClusterizer clusterizer = new DataClusterizer(patentTitles);

            var clustersId = clusterizer.ClusterResults
                .Select(id => id.ClusterId)
                .ToList();

            scores = clusterizer.ClusterResults
                .Select(score => score.Score)
                .ToList();

            var numberOfClusters = clusterizer.OptimalNumberOfClusters;

            resultAxis = new Dictionary<List<double>, string>();
            resultAxis = charts.CreateScatterPlot(cartesianChart_scatterPlot, patentTitles, clustersId, scores, numberOfClusters);
        }

        private void cartesianChart_scatterPlot_DataClick(object sender, ChartPoint chartPoint)
        {
            if (popup != null)
                popup.Close();

            double x = chartPoint.X;
            double y = chartPoint.Y;

            string label = "Not found";
            foreach (var el in resultAxis)
            {
                if (el.Key.SequenceEqual(new List<double>() { x, y }))
                {
                    label = el.Value;
                    break;
                }
            }

            Point startPosition = Cursor.Position;
            Point location = new Point(startPosition.X - 200, startPosition.Y + 40);
            popup = new Popup(label, location);
            popup.Show();
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
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.TopCenter
            };
            
            Label valueLabel = new Label()
            {
                Text = value,
                ForeColor = Color.FromArgb(27, 117, 208),
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.TopCenter
            };

            tableLayoutPanel.Controls.Add(keyLabel, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(valueLabel, 1, tableLayoutPanel.RowCount - 1);
        }
    }
}
