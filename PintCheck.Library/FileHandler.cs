using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace PintCheck.Library
{
    public class FileHandler
    {
        private readonly string _filename;
        private bool _fileExists = false;
        private object _threadLock = new object();
        private readonly StringBuilder _sb = new StringBuilder();

        public FileHandler(string filename)
        {
            _filename = filename;
            _fileExists = File.Exists(_filename);
        }

        bool Write()
        {
            try
            {
                using (var stream = File.Open(_filename, FileMode.Append, FileAccess.Write, FileShare.Read))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(_sb.ToString());
                    _sb.Clear();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Write(List<ICsv> data)
        {
            if (data == null || !data.Any())
                return true;

            lock (_threadLock)
            {
                if (!_fileExists)
                {
                    _sb.AppendLine(data.First().CsvHeader);
                    _fileExists = true;
                }

                data.ForEach(_ => _sb.AppendLine(_.ToString()));
                return Write();
            }
        }
    }
}
