using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;

namespace PintCheck.Library
{
    public class WifiData : ICsv
    {
        public string SSID { get; set; }

        public uint Strength { get; set; }

        #region ICsv Members

        public string CsvHeader
        {
            get { return "SSID;Strength"; }
        }

        public override string ToString()
        {
            var ssid = string.IsNullOrWhiteSpace(SSID) ? "-" : SSID;
            var strength = string.IsNullOrWhiteSpace(SSID) ? "-" : Strength.ToString();

            return String.Format("{0};{1}", ssid, strength);
        }

        #endregion
    }
}
