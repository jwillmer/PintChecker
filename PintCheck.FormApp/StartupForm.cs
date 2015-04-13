using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;
using PintCheck.Library;
using Timer = System.Timers.Timer;

namespace PintCheck.FormApp
{
    public partial class StartupForm : Form
    {
        bool _isRunning = false;
        private static readonly ArgumentOptions Arguments = new ArgumentOptions();
        private readonly Timer _timer = new Timer();

        public StartupForm()
        {
            InitializeComponent();
            DisplayTitle();
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void DisplayTitle()
        {
            Text += string.Format(" V{0}", Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void btn_ExecuteClick(object sender, EventArgs e)
        {
            if (_isRunning) // stop
            {
                _timer.Enabled = false;
            }
            else // start
            {
                SetArguments();
                _timer.Interval = Arguments.Interval * 1000;
                _timer.Enabled = true;
            }

            HandleState();
        }

        private void HandleState()
        {
            if (_isRunning) // stop
            {
                pgb_running.Style = ProgressBarStyle.Continuous;
                pgb_running.MarqueeAnimationSpeed = 0;
                SetSettingsReadonly(false);
                btn_Execute.Text = "Start";
                lbl_state.Text = "Stoped";
                _isRunning = false;
            }
            else // start
            {
                pgb_running.Style = ProgressBarStyle.Marquee;
                pgb_running.MarqueeAnimationSpeed = 30;
                SetSettingsReadonly(true);
                btn_Execute.Text = "Stop";
                lbl_state.Text = "Running";
                _isRunning = true;
            }
        }

        private void SetArguments()
        {
            Arguments.File = txb_file.Text;
            Arguments.Interval = Int32.Parse(txb_interval.Text);
            Arguments.Loops = Int32.Parse(txb_loops.Text);
            Arguments.Timeout = Int32.Parse(txb_timeout.Text);
            Arguments.Url = txb_url.Text;
            Arguments.Url2 = txb_url2.Text;
            Arguments.WiFi = ckb_wifi.Checked;
        }

        private void SetSettingsReadonly(bool isReadOnly)
        {
            var enabled = !isReadOnly;
            foreach (var control in gb_Settings.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled = enabled;
                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Enabled = enabled;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Enabled = enabled;
                }
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var list = new List<PintCheckData>();
            var url = new Uri(Arguments.Url);
            list.Add(GetData(url));

            if (!string.IsNullOrWhiteSpace(Arguments.Url2))
            {
                url = new Uri(Arguments.Url2);
                list.Add(GetData(url));
            }

            FileHandler.WriteToFile(list.Cast<ICsv>().ToList(), Arguments.File);

            var first = list.First();
            var state = string.Format("{0} - Average: {1}ms; Jitter: {2}ms; Loss: {3}%; Corruption: {4}%",
                            first.PingData.Date.ToLongTimeString(),
                            first.PingData.Average,
                            first.PingData.Jitter,
                            first.PingData.DataLoss * 100,
                            first.PingData.DataCorruption * 100);
            SetStateText(state);
        }

        private PintCheckData GetData(Uri url)
        {
            var data = new PintCheckData
            {
                PingData = PingData.PingTimeAverage(url, Arguments.Loops, Arguments.Timeout)
            };

            if (Arguments.WiFi)
            {
                data.WifiData = WifiData.GetWifiData();
            }

            return data;
        }

        delegate void SetTextCallback(string text);
        private void SetStateText(string text)
        {
            if (lbl_state.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetStateText);
                Invoke(d, new object[] { text });
            }
            else
            {
                lbl_state.Text = text;
            }
        }

        #region Minimize to tray

        private void StartupForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                nfi_tray.Visible = true;
                nfi_tray.ShowBalloonTip(3000);
                Hide();
            }

            else if (FormWindowState.Normal == WindowState)
            {
                nfi_tray.Visible = false;
            }
        }

        private void nfi_tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        #endregion
    }
}
