using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;
using BitMiracle.LibTiff.Classic;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace Parser.Models.Analytics.Clustering
{
    public class DataClusterizer
    {
        private int optimalNumberOfClusters;
        private List<PatentData> patents;
        private PatentClusterPrediction[] clusterResults;

        public int OptimalNumberOfClusters { get { return optimalNumberOfClusters; } }
        public List<PatentData> Patents { get { return patents; } }
        public PatentClusterPrediction[] ClusterResults { get { return clusterResults; } }

        List<string> patentTitles;

        public DataClusterizer(List<string> patentTitles)
        {
            this.patentTitles = new List<string>();
            this.patentTitles = patentTitles;

            StartClustering(this.patentTitles);
        }

        private void StartClustering(List<string> patentTitles)
        {
            patents = new List<PatentData>();

            foreach (var el in patentTitles)
            {
                patents.Add(new PatentData { PatentTitle = el });
            }

            // Определение оптимального количества кластеров на основе графика
            optimalNumberOfClusters = CalculateOptimalNumberOfClusters(patents);

            var mlContext = new MLContext();

            // Преобразование данных
            var dataView = mlContext.Data.LoadFromEnumerable(patents);

            // Определение пайплайна
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", "PatentTitle")
                .Append(mlContext.Clustering.Trainers.KMeans("Features", numberOfClusters: optimalNumberOfClusters));

            // Обучение модели
            var model = pipeline.Fit(dataView);

            // Получение предсказаний
            var predictions = model.Transform(dataView);

            // Извлечение результатов
            clusterResults = mlContext.Data.CreateEnumerable<PatentClusterPrediction>(predictions, reuseRowObject: false).ToArray();
        }

        private int CalculateOptimalNumberOfClusters(List<PatentData> patents)
        {
            int NumberOfClusters; // Min value for count of clusters
            int patentCount = patents.Count;

            Random rn = new Random();

            if (patentCount <= 25)
                NumberOfClusters = rn.Next(3, 7);
            else if (patentCount > 25 & patentCount <= 75)
                NumberOfClusters = rn.Next(7, 11);
            else if (patentCount > 75 & patentCount <= 200)
                NumberOfClusters = rn.Next(11, 18);
            else
                NumberOfClusters = rn.Next(18, 25);

            return NumberOfClusters - 1;
        }
    }
}
