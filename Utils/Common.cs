using System;
using System.Collections.Generic;
using System.Xml;
using System.Text.RegularExpressions;

namespace Utils
{
    public class Common
    {
        public string getMask(int Masklen)
        {
            if (Masklen >= 0 && Masklen <= 32)
            {
                uint iMask = 0xFFFFFFFF;
                Masklen = 32 - Masklen;
                iMask <<= Masklen;
                byte a = (byte)((iMask & 0xFF000000) >> 0x18);//24
                byte b = (byte)((iMask & 0x00FF0000) >> 0x10);//16
                byte c = (byte)((iMask & 0x0000FF00) >> 0x8);//8
                byte d = (byte)(iMask & 0x000000FF);
                string mask = String.Format("{0}.{1}.{2}.{3}", a, b, c, d);
                return mask;
            }
            else
            {
                return null;
            }
        }

        public System.Collections.ArrayList getLoopBacks()
        {
            System.Collections.ArrayList LoopBacks = new System.Collections.ArrayList();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("LoopBack.xml");
            XmlNode root = xmlDoc.SelectSingleNode("root");//查找 
            XmlNodeList xnl = root.ChildNodes;
            foreach (XmlNode xnf in xnl)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                XmlElement xe = (XmlElement)xnf;
                XmlNodeList xnf1 = xe.ChildNodes;
                foreach (XmlNode xn2 in xnf1)
                {
                    dic.Add(xn2.Name, xn2.InnerText);
                }
                LoopBacks.Add(dic);
            }
            return LoopBacks;
        }
        public string formatIP(string ipstr, bool single = false)
        {
            string ipaddress_formated = ipstr.Split('/')[0];
            if (single) return ipaddress_formated;
            int mask = 32;
            if (ipstr.Split('/').Length > 1)
            {
                int.TryParse(ipstr.Split('/')[1], out mask);
            }
            ipaddress_formated += " " + this.getMask(mask);
            return ipaddress_formated;
        }
        public string ipPool(string ipstr)
        {
            string start_ip = ipstr.Split('/')[0];
            int mask = 32;
            if (ipstr.Split('/').Length > 1)
            {
                int.TryParse(ipstr.Split('/')[1], out mask);
            }
            string end_ip = LongToIP(IP2Long(start_ip) + Convert.ToInt64(Math.Pow(2, 32 - mask) - 1));
            return start_ip += " " + end_ip; ;

        }
        public bool IsIP(string ip)
        {
            //判断是否为IP
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)(|\/\d\d?)$");
        }
        public bool IsEN(string s)
        {
            //判断是否为IP
            return Regex.IsMatch(s, @"^[a-zA-Z0-9\.]+$");
        }
        static public string LongToIP(long longIP)
        {
            string ip = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                int num = (int)(longIP / Math.Pow(256, (3 - i)));
                longIP = longIP - (long)(num * Math.Pow(256, (3 - i)));
                if (i == 0)
                    ip = num.ToString();
                else
                    ip = ip + "." + num.ToString();
            }
            return ip;
        }

        public static long IP2Long(string ip)
        {
            string[] ipBytes;
            double num = 0;
            if (!string.IsNullOrEmpty(ip))
            {
                ipBytes = ip.Split('.');
                for (int i = ipBytes.Length - 1; i >= 0; i--)
                {
                    num += ((int.Parse(ipBytes[i]) % 256) * Math.Pow(256, (3 - i)));
                }
            }
            return (long)num;
        }

    }
}
