using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Timers;
using CommandLine;
using PintCheck.Library;

namespace PintCheck.ConsoleApp
{
    class Program
    {
        private static int _printedLines = 0;
        private static readonly ArgumentOptions Arguments = new ArgumentOptions();
        private static readonly string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static FileHandler _fileHandler;

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments(args, Arguments);

            _fileHandler = new FileHandler(Arguments.File);
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = Arguments.Interval * 1000;
            timer.Enabled = true;

            PrintHeaderInformations();
            while (Console.Read() != 'q') { }
        }

        static void PrintLine(string line)
        {
            if (_printedLines >= 15)
            {
                _printedLines = 0;
                Console.Clear();
                PrintHeaderInformations();
            }

            Console.WriteLine(line);
            _printedLines++;
        }

        static void PrintHeaderInformations()
        {
            Console.WriteLine("Version: {0}", Version);
            Console.WriteLine("Interval: {0}sec", Arguments.Interval);
            Console.WriteLine("Loops: {0}", Arguments.Loops);
            Console.WriteLine("Url: {0}", Arguments.Url);
            Console.WriteLine("Secondary Url: {0}", Arguments.Url2);
            Console.WriteLine("Wifi tracking: {0}", Arguments.Wifi);
            Console.WriteLine("Output file: {0}", Arguments.File);
            Console.WriteLine("");
            Console.WriteLine("Press \'q\' to quit.");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var list = new List<PintCheckData>();
            var url = new Uri(Arguments.Url);
            list.Add(GetData(url));

            if (!string.IsNullOrWhiteSpace(Arguments.Url2))
            {
                url = new Uri(Arguments.Url2);
                list.Add(GetData(url));
            }

            var writeSuccess = _fileHandler.Write(list.Cast<ICsv>().ToList());

            foreach (var data in list)
            {
                var state = string.Format("{0} - Average: {1}ms; Jitter: {2}ms; Loss: {3}%; Corruption: {4}%",
                    data.PingData.Date.ToLongTimeString(),
                    data.PingData.Average,
                    data.PingData.Jitter,
                    data.PingData.DataLoss * 100,
                    data.PingData.DataCorruption * 100);
                PrintLine(state);
            }

            if (!writeSuccess)
            {
                PrintLine(">> Output file can not be saved! (already opened?)");
            }
        }

        private static PintCheckData GetData(Uri url)
        {
            var data = new PintCheckData
            {
                PingData = PingData.PingTimeAverage(url, Arguments.Loops, Arguments.Timeout)
            };

            if (Arguments.Wifi)
            {
                data.WifiData = WifiData.GetWifiData();
            }

            return data;
        }
    }
}
