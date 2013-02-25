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

            // vpn 
            //public int id { get; set; }
            //public string vpn_name { get; set; }
            //public string source { get; set; }
            //public string destination { get; set; }
            //public string ipaddress { get; set; }
            //public string route { get; set; }
            //public string source1 { get; set; }
            //public string destination1 { get; set; }
            //public string ipaddress1 { get; set; }
            //public string route1 { get; set; }
            //public string memo { get; set; }
            //public string distinction { get; set; }
            string pattern_vpn = @".*?ip vpn-instance vpn\.(?<vpn_name>.*?)\s*?.*?route-distinguisher (?<vpn_id>\d+:\d+)\s";
            r = new Regex(pattern_vpn, RegexOptions.Multiline);
            matchCollection = r.Matches(script);
            ModelVPN.truncate();
            foreach (Match m in matchCollection)
            {
                string vpn_name = "vpn." + m.Groups["vpn_name"].Value;
                string vpn_id = m.Groups["vpn_id"].Value;
                VPN v = ModelVPN.create_new(vpn_name, vpn_id);
                // tunnel1
                string pattern_interface = @"(?s)interface Tunnel.*?ip binding vpn-instance " + vpn_name + @"(?<interface_section>.*?)interface"; //[\d\/]+\s+.*?ip binding vpn-instance " + vpn_name + @"\s*.*?ip address (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s*.*?source (?<source>)";
                Regex cr = new Regex(pattern_interface, RegexOptions.Multiline);
                MatchCollection cmatchCollection = cr.Matches(script);

                if (cmatchCollection.Count > 0)
                {
                    Match cm = cmatchCollection[0];
                    // string tunnel_id = cm.Groups["tunnel_id"].Value;
                    string interface_section = cm.Groups["interface_section"].Value;
                    // test += tunnel_id + "\n";
                    string pattern_interface_binding = @"(?s)^\s*?ip address (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s+.*?source (?<source>.+?)\s.*?destination (?<destination>.+?)\s";
                    Regex ccr = new Regex(pattern_interface_binding, RegexOptions.Multiline);
                    MatchCollection ccmatchCollection = ccr.Matches(interface_section);

                    Match ccm = ccmatchCollection[0];
                    string ip1 = ccm.Groups["ip1"].Value;
                    string ip2 = ccm.Groups["ip2"].Value;
                    string source = ccm.Groups["source"].Value;
                    string destination = ccm.Groups["destination"].Value;
                    v.ipaddress = ip1 + "," + ip2;
                    v.source = source;
                    v.destination = destination;
                    v.route = ""; //todo

                    if (cmatchCollection.Count > 1)
                    {
                        // might be tunnel 2
                        cm = cmatchCollection[1];
                        interface_section = cm.Groups["interface_section"].Value;
                        ccr = new Regex(pattern_interface_binding, RegexOptions.Multiline);
                        ccmatchCollection = ccr.Matches(interface_section);
                        ccm = ccmatchCollection[0];
                        ip1 = ccm.Groups["ip1"].Value;
                        ip2 = ccm.Groups["ip2"].Value;
                        source = ccm.Groups["source"].Value;
                        destination = ccm.Groups["destination"].Value;
                        v.ipaddress1 = ip1 + "," + ip2;
                        v.source1 = source;
                        v.destination1 = destination;
                        v.route1 = "";  //todo
                    }
                }
                v.save();
                this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
                Application.DoEvents();
            }

            //string pattern_apn = @"apn (?<apn_name>.*?)\s*?.*?vpn-instance (?<vpn_name>.*?)\s*?.*?address-pool (?<address>.*?)\s";
            string pattern_apn = @"(?s).*?apn (?<apn_name>.*?)\s+.*?vpn-instance (?<vpn_name>.*?)\s+.*?address-pool (?<address>.*?)\s";
            r = new Regex(pattern_apn, RegexOptions.Multiline);
            matchCollection = r.Matches(script);
            ModelAPN.truncate();
            foreach (Match m in matchCollection)
            {
                string apn_name = m.Groups["apn_name"].Value;
                APN a = ModelAPN.create_new(apn_name);
                string vpn_name = m.Groups["vpn_name"].Value;
                a.set_vpn_by_name(vpn_name);
                string address_pool = m.Groups["address"].Value;
                // test += apn_name + "|" + vpn_name + "|" + address_pool + "\n";

                string pattern_pool = @"(?s)^\s*?ip pool "+ address_pool + @" local .*?vpn-instance " + vpn_name + @"\s+(?<ipsections>(.*?))ip pool";

                // todo bug 麻痹
                Regex cr = new Regex(pattern_pool, RegexOptions.Multiline);
                MatchCollection cmatchCollection = cr.Matches(script);
                if (cmatchCollection.Count > 0)
                {
                    Match cm = cmatchCollection[0];
                    string ipsections = cm.Groups["ipsections"].Value;
                    string pattern_section = @"section (?<section_id>\d+) (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s*?(?<static>\w*)$";
                    Regex ccr = new Regex(pattern_section, RegexOptions.Multiline);
                    MatchCollection ccmatchCollection = ccr.Matches(ipsections);

                    string ip = "";
                    string is_static = "";

                    foreach (Match ccm in ccmatchCollection)
                    {
                        string section_id = ccm.Groups["section_id"].Value;
                        string ip1 = ccm.Groups["ip1"].Value;
                        string ip2 = ccm.Groups["ip2"].Value;
                        is_static = ccm.Groups["static"].Value;
                        ip += ip1 + "," + ip2 + ";";
                        // test += section_id + "|" + ip1 + "|" + ip2 + "|" + is_static + "\n";
                    }

                    if (ccmatchCollection.Count > 0)
                    {
                        a.sim_ip = ip.Substring(0, ip.Length - 1);
                        a.is_static = is_static;
                    }
                }

                a.save();
                this.progressBar1.Value = (this.progressBar1.Value + 1) % 100;
                Application.DoEvents();
            }
            
            this.progressBar1.Value = 99;
            Application.DoEvents();
            MessageBox.Show(test);
        }
    }
}
