//***************************************************************************
// MMMM  MMMMM  OMMM   MMMO    OMMM    OMMM    OMMMMO     OMMMMO    OMMMMO  '
//  MM    MM   MM MM    MMMO  OMMM    MM MM    MM   MO   OM    MO  OM    MO '
//  MM  MM    MM  MM    MM  OO  MM   MM  MM    MM   MO   OM    MO       OMO '
//  MMMM     MMMMMMMM   MM  MM  MM  MMMMMMMM   MMMMMO     OMMMMO      OMO   '
//  MM  MM        MM    MM      MM       MM    MM   MO   OM    MO   OMO     '
//  MM    MM      MM    MM      MM       MM    MM    MO  OM    MO  OM   MM  '
// MMMM  MMMM    MMMM  MMMM    MMMM     MMMM  MMMM  MMMM  OMMMMO   MMMMMMM  '
//                                                                          '
// K4m4r82's Laboratory                                                     '
// http://coding4ever.wordpress.com                                         '
//***************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using Microsoft.Win32;

namespace WiFiProfiles
{
    public partial class FrmMain : Form
    {
        private const int timeout = 5000;
        private const string key = @"Software\Coding4Ever-WiFi-Profiles";
        List<string> output = new List<string>();

        public FrmMain()
        {
            InitializeComponent();
        }

        // method untuk membaca registry
        private string GetValue(string key, string value)
        {
            return Registry.CurrentUser.OpenSubKey(key).GetValue(value).ToString();
        }

        // method untuk menulis registry
        private void WriteValue(string key, string valueName, string value)
        {
            Registry.CurrentUser.CreateSubKey(key).SetValue(valueName, value);
        }

        // method untuk membaca setting program terakhir
        private void GetSetting()
        {
            output.Clear();
            ExecuteCommand("netsh", "int ip show config", timeout, true);
            cmbNetworkConnection.Items.AddRange(GetNetworkConnections());

            string defaultNetwork = string.Empty;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(key);
            if (registryKey != null)
            {
                defaultNetwork = GetValue(key, "DefaultNetwork");
                txtIPAddress.Text = GetValue(key, "IPAddress");
                txtSubnetMask.Text = GetValue(key, "SubnetMask");
                txtDefaultGateway.Text = GetValue(key, "DefaultGateway");
                txtDnsServer1.Text = GetValue(key, "DnsServer1");
                txtDnsServer2.Text = GetValue(key, "DnsServer2");

                switch (GetValue(key, "IPAktif"))
                {
                    case "1": // dinamis
                        rdoIPDinamis.Checked = true;
                        break;

                    case "2": // statis
                        rdoIPStatis.Checked = true;
                        break;

                    default:
                        rdoIPDinamis.Checked = true;
                        break;
                }

                groupBox1.Enabled = rdoIPStatis.Checked;
            }
            else
            {
                // do nothing
            }

            if (defaultNetwork.Length > 0)
            {
                if (cmbNetworkConnection.Items.Count > 0) cmbNetworkConnection.Text = defaultNetwork;
            }
            else
            {
                if (cmbNetworkConnection.Items.Count > 0) cmbNetworkConnection.SelectedIndex = 0;
            }
        }

        private string[] GetNetworkConnections()
        {
            string[] arrNetwork = null;

            if (output.Count > 0)
            {
                arrNetwork = new string[output.Count];
                int index = 0;
                foreach (string var in output)
                {
                    string[] networkConnection = var.Split('\"');
                    arrNetwork[index] = networkConnection[1];

                    index++;
                }
            }

            return arrNetwork;
        }

        private void ExecuteCommand(string cmd, string parameter, int timeout, bool redirectStandardOutput)
        {
            Process p = new Process();

            p.StartInfo.FileName = cmd;
            p.StartInfo.Arguments = parameter;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = redirectStandardOutput;

            try
            {
                p.Start();

                if (redirectStandardOutput)
                {
                    p.BeginOutputReadLine();
                    p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                }

                p.WaitForExit(timeout);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                p.Close();
            }
        }

        // delegate method
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Length > 0)
                    if (!(e.Data.IndexOf("Configuration for interface") < 0)) output.Add(e.Data);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string parameter = string.Empty;

            if (MessageBox.Show("Apakah proses ingin dilanjutkan ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                btnOk.Enabled = false;

                if (rdoIPDinamis.Checked) // ip dinamis
                {                    
                    parameter = "interface ipv4 set address name=\"" + cmbNetworkConnection.Text + "\" source=dhcp";
                    ExecuteCommand("netsh", parameter, timeout, false);

                    parameter = "interface ipv4 set dnsserver \"" + cmbNetworkConnection.Text + "\" dhcp";
                    ExecuteCommand("netsh", parameter, timeout, false);
                }
                else // ip statis
                {
                    parameter = "interface ipv4 set address name=\"" + cmbNetworkConnection.Text + "\" source=static address=" + txtIPAddress.Text + " mask=" + txtSubnetMask.Text + " gateway=" + txtDefaultGateway.Text;
                    ExecuteCommand("netsh", parameter, timeout, false);

                    parameter = "interface ipv4 add dnsserver name=\"" + cmbNetworkConnection.Text + "\" address=" + txtDnsServer1.Text + " index=1";
                    ExecuteCommand("netsh", parameter, timeout, false);

                    parameter = "interface ipv4 add dnsserver name=\"" + cmbNetworkConnection.Text + "\" address=" + txtDnsServer2.Text + " index=2";
                    ExecuteCommand("netsh", parameter, timeout, false);

                    WriteValue(key, "IPAddress", txtIPAddress.Text);
                    WriteValue(key, "SubnetMask", txtSubnetMask.Text);
                    WriteValue(key, "DefaultGateway", txtDefaultGateway.Text);
                    WriteValue(key, "DnsServer1", txtDnsServer1.Text);
                    WriteValue(key, "DnsServer2", txtDnsServer2.Text);                    
                }

                WriteValue(key, "DefaultNetwork", cmbNetworkConnection.Text);
                WriteValue(key, "IPAktif", rdoIPDinamis.Checked ? "1" : "2");
                btnOk.Enabled = true;

                Cursor.Current = Cursors.Default;
            }
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSetting();
        }

        private void rdoIPDinamis_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void rdoIPStatis_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
        
    }
}