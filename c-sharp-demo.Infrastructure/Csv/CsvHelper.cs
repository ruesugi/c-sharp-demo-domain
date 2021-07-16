using System.Collections.Generic;
using System.IO;
using System.Text;

namespace c_sharp_demo.Infrastructure.Csv
{
    internal class CsvHelper
    {
        internal static void SaveSingle(string filePath, List<string> parameters)
        {
            using (var sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                var sb = new StringBuilder();
                foreach (var parameter in parameters)
                {
                    sb.Append(parameter + ",");
                }
                sb.Length -= 1; // 末尾のカンマを削除する.
                sw.WriteLine(sb.ToString());
            }
        }

        internal static string[] ReadAll(string filePath)
        {
            if (File.Exists(filePath)) return File.ReadAllLines(filePath, Encoding.UTF8);

            return new string[0];
        }
    }
}
