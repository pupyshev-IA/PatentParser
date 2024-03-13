using Microsoft.ML.Data;

namespace Parser.Models.Analytics.Clustering
{
    public class PatentData
    {
        [LoadColumn(0)]
        public string PatentTitle;
    }

    public class PatentClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint ClusterId;

        [VectorType(3), ColumnName("Features")]
        public float[] Features;

        [ColumnName("Score")]
        public float[] Score;
    }
}
