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
using System.Security.RightsManagement;

namespace Parser.Models.Analytics
{
    public class LiveChart
    {
        public void CreateColumnChart(LiveCharts.WinForms.CartesianChart cartesianChart_dates, List<string> labels, List<int> values)
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
                //LabelFormatter = value => value.ToString("N")
            });
        }

        public void CreatePieChart(SolidGauge solidGauge_docAmount, int fullAmount, int parsedAmount)
        {
            solidGauge_docAmount.From = 0;
            solidGauge_docAmount.To = fullAmount;
            solidGauge_docAmount.Value = parsedAmount;
            solidGauge_docAmount.FromColor = Color.FromArgb(0, 156, 69, 207);
        }
    }
}
