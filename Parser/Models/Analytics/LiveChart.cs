using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Media;
using LiveCharts.Definitions.Charts;
using LiveCharts.Defaults;
using System.ComponentModel;

namespace Parser.Models.Analytics
{
    public class LiveChart
    {
        public void CreatePieChart(SolidGauge solidGauge_docAmount, int fullAmount, int parsedAmount)
        {
            solidGauge_docAmount.From = 0;
            solidGauge_docAmount.To = fullAmount;
            solidGauge_docAmount.Value = parsedAmount;
            solidGauge_docAmount.FromColor = Color.FromArgb(0, 156, 69, 207);
        }

        public void CreateColumnChart(LiveCharts.WinForms.CartesianChart cartesianChart_dates, 
            List<string> labels, List<int> values)
        {
            cartesianChart_dates.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<int>(values),
                    Fill = Brushes.OrangeRed
                }
            };

            cartesianChart_dates.AxisX.Add(new Axis
            {
                Title = "Dates",
                FontSize = 14,
                FontFamily = new FontFamily("Segoe UI"),
                Foreground = Brushes.Black,
                Labels = labels
            });

            cartesianChart_dates.AxisY.Add(new Axis
            {
                Title = "Docs Amount",
                FontSize = 14,
                FontFamily = new FontFamily("Segoe UI"),
                Foreground = Brushes.Black,
            });
        }

        public Dictionary<List<double>, string> CreateScatterPlot(LiveCharts.WinForms.CartesianChart cartesianChart_scatterPlot, 
            List<string> titles, List<uint> clustersId, List<float[]> scores, int numberOfClusters)
        {
            Dictionary<List<double>, string> resultAxis = new Dictionary<List<double>, string>();

            Random rn = new Random();
            SeriesCollection seriesCollection = new SeriesCollection();

            for (int i = 1; i <= numberOfClusters; i++)
            {
                int R = rn.Next(0, 255);
                int G = rn.Next(0, 255);
                int B = rn.Next(0, 255);

                var brush = new SolidColorBrush(Color.FromArgb(255, (byte)R, (byte)G, (byte)B));

                var scatterSeries = new ScatterSeries
                {
                    Title = $"Clsuter {i}: ",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Circle,
                    Fill = brush,
                };

                seriesCollection.Add(scatterSeries);
            }

            for (int j = 0; j < titles.Count; j++)
            {
                int cluster = Convert.ToInt32(clustersId[j]);

                double minValue = -0.4;
                double maxValue = 0.4;
                double x = cluster + (rn.NextDouble() * (maxValue - minValue) + minValue);
                double y = scores[j][cluster - 1];

                resultAxis.Add(new List<double>() { x, y }, titles[j]);

                seriesCollection[cluster - 1].Values.Add
                (
                    new ObservablePoint(x, y)
                );
            }

            cartesianChart_scatterPlot.AxisX.Add(new Axis
            {
                MinValue = 0,
                MaxValue = numberOfClusters + 1,
                Title = "Clusters",
                FontSize = 14,
                FontFamily = new FontFamily("Segoe UI"),
                Foreground = Brushes.Black,
            });

            cartesianChart_scatterPlot.AxisY.Add(new Axis
            {
                Title = "Scores",
                FontSize = 14,
                FontFamily = new FontFamily("Segoe UI"),
                Foreground = Brushes.Black,
            });

            cartesianChart_scatterPlot.Series = seriesCollection;
            cartesianChart_scatterPlot.LegendLocation = LegendLocation.Bottom;

            return resultAxis;
        }
    }
}
