using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Parser.Models.Analytics;
using Parser.Models.Parsers;

namespace Parser.UI.Analytics.DashboardOptions
{
    public partial class PatentInfo : Form
    {
        private string link, previousLink, docNum;
        private int rowIndex;
        public string Link { set => link = value; }
        public string DocNum{ set => docNum = value; }
        public int RowIndex { set => rowIndex = value; }

        Image baseImage;
        Dictionary<string, string> resultInfo;
        PatentInfoScraper scraper;
        LiveChart charts;
        RequestInfo requestInfo;

        public PatentInfo(RequestInfo requestInfo)
        {
            InitializeComponent();

            this.requestInfo = requestInfo;

            scraper = new PatentInfoScraper();
            charts = new LiveChart();

            baseImage = pictureBox.Image;
        }

        private void pictureBox_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                if (link != previousLink)
                {
                    previousLink = link;
                    FetchInfo();
                }
        }

        private void FetchInfo()
        {
            switch (true)
            {
                case var _ when link.Contains("espacenet"):
                    {
                        resultInfo = scraper.FetchEspacenetPatent(link, docNum);
                        SetData(resultInfo);
                        break;
                    }
                case var _ when link.Contains("yandex"):
                    {
                        resultInfo = scraper.FetchYandexPatentsPatent(link, docNum);
                        SetData(resultInfo);
                        break;
                    }
                case var _ when link.Contains("fips"):
                    {
                        resultInfo = scraper.FetchFipsPatent(link, docNum);
                        SetData(resultInfo);
                        break;
                    }
                case var _ when link.Contains("wipo"):
                    {
                        break;
                    }
            }
        }

        private void SetData(Dictionary<string, string> dict)
        {
            if (dict != null && dict.Count > 0)
            {
                lblName_text.Text = dict["Название"];
                lblDocNum_text.Text = dict["Номер документа"];
                lblInventor_text.Text = dict["Автор"];
                lblApplicant_text.Text = dict["Заявитель"];
                lblIPC_text.Text = dict["МПК"];
                tbAbstract_text.Text = dict["Реферат"];

                if (!string.IsNullOrEmpty(dict["Изображение"]))
                {
                    byte[] imageBytes = Convert.FromBase64String(dict["Изображение"]);
                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                    pictureBox.Image = image;
                }
                else
                    pictureBox.Image = baseImage;

                var wordFrequency = CountWordFrequency(dict["Реферат"]);
                var labels = wordFrequency.Select(el => el.Key).ToList();
                var values = wordFrequency.Select(el => el.Value).ToList();
                charts.CreateColumnChartForFrequency(cartesianChart_keys, labels, values);

                var curScores = requestInfo.Scores[rowIndex];
                charts.CreatePieChart(pieChart_clusters, curScores);
            }
        }

        private Dictionary<string, int> CountWordFrequency(string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] words = tbAbstract_text.Text.Split
            (
                new char[] { ' ', '.', ',', ';', ':', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string word in words)
            {
                string cleanedWord = word.ToLower();

                if (wordFrequency.ContainsKey(cleanedWord))
                    wordFrequency[cleanedWord]++;
                else
                    wordFrequency[cleanedWord] = 1;
            }

            List<string> keysToRemove = new List<string>();
            foreach (var pair in wordFrequency)
                if (pair.Value < 3 || pair.Key.Length < 4)//(wordFrequency.Values.Max() / 2))
                    keysToRemove.Add(pair.Key);

            foreach (string key in keysToRemove)
                wordFrequency.Remove(key);

            return wordFrequency.OrderBy(el => el.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
