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
        public static WifiData GetWifiData()
        {
            WlanClient client = new WlanClient(); // can crash if execution loop is to fast (max wifi client count!)
            var wlanIface = client.Interfaces.FirstOrDefault(_ => _.CurrentConnection.isState == Wlan.WlanInterfaceState.Connected);

            if (wlanIface != null)
            {
                var attributes = wlanIface.CurrentConnection.wlanAssociationAttributes;
                return new WifiData
                {
                    SSID = GetStringForSSID(attributes.dot11Ssid),
                    Strength = attributes.wlanSignalQuality
                };
            }

            return new WifiData();
        }
        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

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
