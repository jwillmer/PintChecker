using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintCheck.Library
{
    public class PintCheckData : ICsv
    {
        public PintCheckData()
        {
            PingData = new PingData();
            WifiData = new WifiData();
        }

        public PingData PingData { get; set; }

        public WifiData WifiData { get; set; }



        #region ICsv Members

        public string CsvHeader
        {
            get
            {
                var header = PingData.CsvHeader;
                header += ";" + WifiData.CsvHeader;

                return header;
            }
        }

        public override string ToString()
        {
            var s = PingData.ToString();
            s += ";" + WifiData.ToString();

            return s;
        }

        #endregion
    }
}
