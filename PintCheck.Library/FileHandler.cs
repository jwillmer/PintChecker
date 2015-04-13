using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PintCheck.Library
{
    public class FileHandler
    {
        public static void WriteToFile(ICsv data, string file)
        {
            if (!File.Exists(file))
            {
                var header = data.CsvHeader + Environment.NewLine;
                File.WriteAllText(file, header);
            }

            var dataLine = data.ToString() + Environment.NewLine;
            File.AppendAllText(file, dataLine);
        }

        public static void WriteToFile(List<ICsv> data, string file)
        {
            foreach (var d in data)
            {
                WriteToFile(d, file);
            }
        }
    }
}
