using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace PintCheck.Library
{
    public class PingData : ICsv
    {
        public PingData()
        {
            Exceptions = new List<Exception>();
            PingReplys = new List<PingReply>();
        }

        public DateTime Date { get; set; }
        public int Timeout { get; set; }
        public string DataString { get; set; }
        public string Host { get; set; }
        public byte[] Data
        {
            get
            {
                return Encoding.ASCII.GetBytes(DataString);
            }
        }
        public List<Exception> Exceptions { get; set; }
        public List<PingReply> PingReplys { get; set; }
        public int Pings { get; set; }


        public double Average
        {
            get
            {
                var successors = PingReplys.Where(_ => _.Status == IPStatus.Success).ToList();
                var roundTripTimeSum = successors.Sum(_ => _.RoundtripTime);

                return successors.Any() ? roundTripTimeSum / successors.Count() : 0;
            }
        }

        public double Jitter
        {
            get
            {
                var roundtripTimes = PingReplys.Where(_ => _.Status == IPStatus.Success).Select(_ => _.RoundtripTime).ToList();
                if (!roundtripTimes.Any()) return 0;

                var minRoundTrip = roundtripTimes.Min(_ => _);
                var maxRoundTrip = roundtripTimes.Max(_ => _);

                return maxRoundTrip - minRoundTrip;
            }
        }

        public int DataLoss
        {
            get
            {
                var lost = PingReplys.Count(_ => _.Status != IPStatus.Success);
                lost += Exceptions.Count();
                return lost / Pings;
            }
        }

        public int DataCorruption
        {
            get
            {
                var successors = PingReplys.Where(_ => _.Status == IPStatus.Success).ToList();
                var corruptionCount = successors.Count(_ => Encoding.ASCII.GetString(_.Buffer) != DataString);

                return successors.Any() ? corruptionCount / successors.Count : 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6}",
                Date.ToShortDateString(),
                Date.ToLongTimeString(),
                Average,
                Jitter,
                DataLoss,
                DataCorruption,
                Host);
        }

        public string CsvHeader
        {
            get { return "Date;Time;Average;Jitter;DataLoss;DataCorruption;Host"; }
        }

        public static PingData PingTimeAverage(Uri url, int echoNum, int timeout)
        {
            var data = new PingData
            {
                DataString = "11112222333344445555666677778888",
                Host = url.Host,
                Timeout = timeout,
                Date = DateTime.Now,
                Pings = echoNum
            };

            using (Ping pingSender = new Ping())
            {
                PingOptions options = new PingOptions(data.Timeout, true);

                for (int i = 0; i < data.Pings; i++)
                {
                    try
                    {
                        PingReply reply = pingSender.Send(url.Host, data.Timeout, data.Data, options);
                        data.PingReplys.Add(reply);
                    }
                    catch (Exception e)
                    {
                        data.Exceptions.Add(e);
                    }
                }
            }
            return data;
        }
    }
}
