using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;

namespace PintCheck.Library
{
    public class WifiHandler
    {
        private WlanClient _client = new WlanClient();
        private WlanClient.WlanInterface _interface;

        public WifiHandler()
        {
            _interface = _client.Interfaces.FirstOrDefault(_ => _.CurrentConnection.isState == Wlan.WlanInterfaceState.Connected);
        }

        public WifiData GetWifiData()
        {
            if (_interface != null && _interface.CurrentConnection.isState == Wlan.WlanInterfaceState.Connected)
            {
                var attributes = _interface.CurrentConnection.wlanAssociationAttributes;
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

    }
}
