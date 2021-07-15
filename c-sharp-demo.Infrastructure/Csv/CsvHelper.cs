using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
