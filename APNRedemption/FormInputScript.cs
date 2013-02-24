using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;

namespace APNRedemption
{
    public partial class FormInputScript : Form
    {
        public FormInputScript()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            string script = this.tb_script.Text;

            // loopback
            string pattern_loopback = @"^interface (?<loopback_name>LoopBack\d+?)\s+.*?description (?<description>.*?)\s+.*?ip address (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s+.*?target-board (?<target_board>.*?)\s+.*?binding (?<binding>.*?)\n";
            Regex r = new Regex(pattern_loopback, RegexOptions.Multiline);
            MatchCollection matchCollection = r.Matches(script);
            string test = "";
            ModelLoopBack.truncate();
            foreach (Match m in matchCollection)
            {
                string loopback_name = m.Groups["loopback_name"].Value;
                string description = m.Groups["description"].Value;
                string ip1 = m.Groups["ip1"].Value;
                string ip2 = m.Groups["ip2"].Value;
                string target_board = m.Groups["target_board"].Value;
                string binding = m.Groups["binding"].Value;
                test += loopback_name + "|" + description + "|" + ip1 + "|" + ip2 + "|" + target_board + "|" + binding + "\n";

                LoopBack l = new LoopBack();
                l.loopback_name = loopback_name;
                l.loopback_target_board = target_board;
                l.loopback_ipaddress = ip1 + "/32"; // todo, for ip segment
                l.loopback_discription = description;
                l.loopback_binding = binding;
                l.save();

                this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
                Application.DoEvents();
            }

            //string pattern_vpn = @".*?ip vpn-instance vpn\.(?<vpn_name>.*?)\s*?.*?route-distinguisher (?<vpn_id1>\d+):(?<vpn_id2>\d+)";
            //r = new Regex(pattern_vpn, RegexOptions.Multiline);
            //matchCollection = r.Matches(script);
            //foreach (Match m in matchCollection)
            //{
            //    string vpn_name = "vpn." + m.Groups["vpn_name"].Value;
            //    string vpn_id1 = m.Groups["vpn_id1"].Value;
            //    string vpn_id2 = m.Groups["vpn_id2"].Value;
            //    // test += vpn_name + "|" + vpn_id1 + "|" + vpn_id2 + "\n";

            //    string pattern_interface = @"(?s)interface Tunnel(?<tunnel_id>[\d\/]+)\s+.*?ip binding vpn-instance " + vpn_name + @"(?<interface_section>.*?)interface"; //[\d\/]+\s+.*?ip binding vpn-instance " + vpn_name + @"\s*.*?ip address (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s*.*?source (?<source>)";
            //    Regex cr = new Regex(pattern_interface, RegexOptions.Multiline);
            //    MatchCollection cmatchCollection = cr.Matches(script);

            //    foreach (Match cm in cmatchCollection)
            //    {
            //        string tunnel_id = cm.Groups["tunnel_id"].Value;
            //        string interface_section = cm.Groups["interface_section"].Value;
            //        // test += tunnel_id + "\n";

            //        string pattern_interface_binding = @"(?s)^\s*?ip address (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s+.*?source (?<source>.+?)\s.*?destination (?<destination>.+?)\s";
            //        Regex ccr = new Regex(pattern_interface_binding, RegexOptions.Multiline);
            //        MatchCollection ccmatchCollection = ccr.Matches(interface_section);

            //        foreach (Match ccm in ccmatchCollection)
            //        {
            //            string ip1 = ccm.Groups["ip1"].Value;
            //            string ip2 = ccm.Groups["ip2"].Value;
            //            string source = ccm.Groups["source"].Value;
            //            string destination = ccm.Groups["destination"].Value;
            //            // test += ip1 + ip2 + source + destination + "\n";
            //        }
            //    }
            //    this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
            //    Application.DoEvents();
            //}

            ////string pattern_apn = @"apn (?<apn_name>.*?)\s*?.*?vpn-instance (?<vpn_name>.*?)\s*?.*?address-pool (?<address>.*?)\s";
            //string pattern_apn = @"(?s).*?apn (?<apn_name>.*?)\s+.*?vpn-instance (?<vpn_name>.*?)\s+.*?address-pool (?<address>.*?)\s";
            //r = new Regex(pattern_apn, RegexOptions.Multiline);
            //matchCollection = r.Matches(script);
            //foreach (Match m in matchCollection)
            //{
            //    string apn_name = m.Groups["apn_name"].Value;
            //    string vpn_name = m.Groups["vpn_name"].Value;
            //    string address_pool = m.Groups["address"].Value;
            //    // test += apn_name + "|" + vpn_name + "|" + address_pool + "\n";
            //    this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
            //    Application.DoEvents();
            //}

            //string pattern_pool = @"(?s)^\s*?ip pool (?<address>.*?) local .*?vpn-instance (?<vpn_name>.*?)\s+(?<ipsections>(.*?))ip pool";
            //r = new Regex(pattern_pool, RegexOptions.Multiline);
            //matchCollection = r.Matches(script);
            //foreach (Match m in matchCollection)
            //{
            //    string address_pool = m.Groups["address"].Value;
            //    string vpn_name = m.Groups["vpn_name"].Value;
            //    string ipsections = m.Groups["ipsections"].Value;
            //    string pattern_section = @"section (?<section_id>\d+) (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s*?(?<static>\w*)$";
            //    Regex cr = new Regex(pattern_section, RegexOptions.Multiline);
            //    MatchCollection cmatchCollection = cr.Matches(ipsections);

            //    foreach (Match cm in cmatchCollection)
            //    {
            //        string section_id = cm.Groups["section_id"].Value;
            //        string ip1 = cm.Groups["ip1"].Value;
            //        string ip2 = cm.Groups["ip2"].Value;
            //        string is_static = cm.Groups["static"].Value;
            //        // test += section_id + "|" + ip1 + "|" + ip2 + "|" + is_static + "\n";
            //    }
            //    this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
            //    Application.DoEvents();
            //}

            this.progressBar1.Value = 99;
            Application.DoEvents();
            MessageBox.Show(test);
        }
    }
}
