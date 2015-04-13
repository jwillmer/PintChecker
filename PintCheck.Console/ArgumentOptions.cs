using CommandLine;

namespace PintCheck.ConsoleApp
{
    public class ArgumentOptions
    {
        [Option('l', "loops", DefaultValue = 4, HelpText = "Ping loops to calculate the average time.")]
        public int Loops { get; set; }

        [Option('u', "url", DefaultValue = "http://google-public-dns-a.google.com", HelpText = "The url to test against.")]
        public string Url { get; set; }

        [Option('s', "second_url", HelpText = "The second url to test against.")]
        public string Url2 { get; set; }

        [Option('i', "interval", DefaultValue = 20, HelpText = "The interval that pings will be send in seconds.")]
        public int Interval { get; set; }

        [Option('t', "timeout", DefaultValue = 2000, HelpText = "The timeout for a ping response.")]
        public int Timeout { get; set; }

        [Option('f', "file", DefaultValue = "PingAnalystics.csv", HelpText = "The output file location.")]
        public string File { get; set; }

        [Option('w', "wifi", DefaultValue = false, HelpText = "The options to enable wifi signal strength tracking.")]
        public bool Wifi { get; set; }
    }
}
