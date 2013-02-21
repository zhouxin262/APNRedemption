using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        public static void ImportScript(string script)
        {
            string pattern_vpn = @".*?ip vpn-instance (?<vpn_name>.*?)\s*?.*?route-distinguisher (?<vpn_id1>\d+):(?<vpn_id2>\d+)";
            Regex r = new Regex(pattern_vpn, RegexOptions.Multiline);
            MatchCollection matchCollection = r.Matches(script);
            string test = "";
            foreach (Match m in matchCollection)
            {
                string vpn_name = m.Groups["vpn_name"].Value;
                string vpn_id1 = m.Groups["vpn_id1"].Value;
                string vpn_id2 = m.Groups["vpn_id2"].Value;
                // test += vpn_name + "|" + vpn_id1 + "|" + vpn_id2 + "\n";
            }

            //string pattern_apn = @"apn (?<apn_name>.*?)\s*?.*?vpn-instance (?<vpn_name>.*?)\s*?.*?address-pool (?<address>.*?)\s";
            string pattern_apn = @"(?s).*?apn (?<apn_name>.*?)\s+.*?vpn-instance (?<vpn_name>.*?)\s+.*?address-pool (?<address>.*?)\s";
            r = new Regex(pattern_apn, RegexOptions.Multiline);
            matchCollection = r.Matches(script);
            foreach (Match m in matchCollection)
            {
                string apn_name = m.Groups["apn_name"].Value;
                string vpn_name = m.Groups["vpn_name"].Value;
                string address_pool = m.Groups["address"].Value;
                // test += apn_name + "|" + vpn_name + "|" + address_pool + "\n";
            }

            string pattern_pool = @"(?s)^\s*?ip pool (?<address>.*?) local .*?vpn-instance (?<vpn_name>.*?)\s+(?<ipsections>(.*?))ip pool";
            r = new Regex(pattern_pool, RegexOptions.Multiline);
            matchCollection = r.Matches(script);
            foreach (Match m in matchCollection)
            {
                string address_pool = m.Groups["address"].Value;
                string vpn_name = m.Groups["vpn_name"].Value;
                string ipsections = m.Groups["ipsections"].Value;
                string pattern_section = @"section (?<section_id>\d+) (?<ip1>[\d\.]+) (?<ip2>[\d\.]+)\s*?(?<static>\w*)$";
                Regex cr = new Regex(pattern_section, RegexOptions.Multiline);
                MatchCollection cmatchCollection = cr.Matches(ipsections);

                foreach (Match cm in cmatchCollection)
                {
                    string section_id = cm.Groups["section_id"].Value;
                    string ip1 = cm.Groups["ip1"].Value;
                    string ip2 = cm.Groups["ip2"].Value;
                    string is_static = cm.Groups["static"].Value;
                    test += section_id + "|" + ip1 + "|" + ip2 + "|" + is_static + "\n";
                }

            }
            MessageBox.Show(test);
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            ImportScript(tb_script.Text);
        }
    }
}
