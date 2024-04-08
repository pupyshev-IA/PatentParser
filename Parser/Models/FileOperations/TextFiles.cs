using System.IO;
using System.Collections.Generic;

namespace Parser.Models.FileOperations
{
    public class TextFiles
    {
        public void CreateTextFile(Dictionary<string, string> formData, string filePath, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(filePath + fileName + ".txt", false))
            {
                foreach (KeyValuePair<string, string> dict in formData)
                    writer.WriteLine(dict.Key + ":" + dict.Value);

                writer.Close();
            }
        }
    }
}
