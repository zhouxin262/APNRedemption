using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DAL;
using Utils;

namespace Models
{
    public class VPN
    {
        public int id { get; set; }
        public string vpn_name { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public string ipaddress { get; set; }
        public string route { get; set; }
        public string source1 { get; set; }
        public string destination1 { get; set; }
        public string ipaddress1 { get; set; }
        public string route1 { get; set; }
        public string memo { get; set; }

        // no db
        public bool is_modified { get; set; }
        // after validate 
        public string err { get; set; }
        public string tunnel { get; set; }
        public string tunnel1 { get; set; }
        public string tunnel_id { get; set; }
        public string source_name { get; set; }
        public string tunnel_id1 { get; set; }
        public string source_name1 { get; set; }
        public string ipaddress_formated { get; set; }
        public string destination_formated { get; set; }
        public string ipaddress1_formated { get; set; }
        public string destination1_formated { get; set; }
        public string route_formated { get; set; }
        public string route1_formated { get; set; }

        public void save()
        {
            if (this.id > 0)
            {
                string updateSql = "UPDATE VPN SET vpn_name=@vpn_name, source=@source, destination=@destination, " +
                        "ipaddress=@ipaddress, route=@route,source1=@source1, destination1=@destination1, " +
                        "ipaddress1=@ipaddress1, route1=@route1, [memo]=@memo WHERE id=@id";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = updateSql;
                cmd.Parameters.AddWithValue("@vpn_name", this.vpn_name);
                cmd.Parameters.AddWithValue("@source", this.source);
                cmd.Parameters.AddWithValue("@destination", this.destination);
                cmd.Parameters.AddWithValue("@ipaddress", this.ipaddress);
                cmd.Parameters.AddWithValue("@route", this.route);
                cmd.Parameters.AddWithValue("@source1", this.source1);
                cmd.Parameters.AddWithValue("@destination1", this.destination1);
                cmd.Parameters.AddWithValue("@ipaddress1", this.ipaddress1);
                cmd.Parameters.AddWithValue("@route1", this.route1);
                cmd.Parameters.AddWithValue("@memo", this.memo);
                cmd.Parameters.AddWithValue("@id", this.id);
                DB.excuteSql(cmd);
            }
            else
            {
                string updateSql = "INSERT VPN(vpn_name, source, destination, ipaddress, route, source1, destination1, ipaddress1, route1, [memo])" +
                                   " VALUES(@vpn_name, @source, @destination, @ipaddress, @route, @source1, @destination1, @ipaddress1, @route1, @memo);";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = updateSql;
                cmd.Parameters.AddWithValue("@vpn_name", this.vpn_name);
                cmd.Parameters.AddWithValue("@source", this.source);
                cmd.Parameters.AddWithValue("@destination", this.destination);
                cmd.Parameters.AddWithValue("@ipaddress", this.ipaddress);
                cmd.Parameters.AddWithValue("@route", this.route);
                cmd.Parameters.AddWithValue("@source1", this.source1);
                cmd.Parameters.AddWithValue("@destination1", this.destination1);
                cmd.Parameters.AddWithValue("@ipaddress1", this.ipaddress1);
                cmd.Parameters.AddWithValue("@route1", this.route1);
                cmd.Parameters.AddWithValue("@memo", this.memo);
                DB.excuteSql(cmd);
            }
            this.is_modified = false;
        }
        public bool validate()
        {
            Common c = new Common();
            if (!c.IsEN(this.vpn_name))
            {
                this.err = "vpn名称只能是字母与数字的组合";
                return false;
            }
            if (this.getLoopBack(this.source) == null && this.getLoopBack(this.source1) == null)
            {
                return false;
            }
            else
            {
                try
                {
                    // get tunnel by loopback
                    Dictionary<string, string> loopback = this.getLoopBack(this.source);
                    string discription = loopback["discription"];
                    string[] discription_arr = discription.Split(' ');
                    string tunnel = discription_arr[discription_arr.Length - 1];
                    this.tunnel = tunnel;
                    string[] tunnel_arr = tunnel.Split('/');
                    this.tunnel_id = tunnel_arr[0] + "/" + tunnel_arr[1] + "/" + (this.id * 2 + 99).ToString();
                    this.source_name = loopback["name"];

                    // get tunnel1 by loopback
                    loopback = this.getLoopBack(this.source1);
                    if (loopback != null)
                    {
                        discription = loopback["discription"];
                        discription_arr = discription.Split(' ');
                        tunnel = discription_arr[discription_arr.Length - 1];
                        this.tunnel1 = tunnel;
                        tunnel_arr = tunnel.Split('/');
                        this.tunnel_id1 = tunnel_arr[0] + "/" + tunnel_arr[1] + "/" + (this.id * 2 + 100).ToString();
                        this.source_name1 = loopback["name"];
                    }

                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            if (c.IsIP(this.ipaddress))
            {
                this.ipaddress_formated = c.formatIP(this.ipaddress);
            }
            else
            {
                this.err = "本端私网地址格式错误";
                return false;
            }
            if (this.ipaddress1 != null && this.ipaddress1 != "")
            {
                if (c.IsIP(this.ipaddress1))
                {
                    this.ipaddress1_formated = c.formatIP(this.ipaddress1);
                }
                else
                {
                    this.err = "隧道2本端私网地址格式错误";
                    return false;
                }
            }
            if (c.IsIP(this.destination))
            {
                this.destination_formated = c.formatIP(this.destination, true);
            }
            else
            {
                this.err = "对端公网地址格式错误";
                return false;
            }
            if (this.destination1 != null && this.destination1 != "")
            {
                if (c.IsIP(this.destination1))
                {
                    this.destination1_formated = c.formatIP(this.destination1, true);
                }
                else
                {
                    this.err = "隧道2对端公网地址格式错误";
                    return false;
                }
            }

            if (c.IsIP(this.route))
            {
                this.route_formated = c.formatIP(this.route);
            }
            else
            {
                this.err = "对端私网地址格式错误";
                return false;
            }
            if (this.route1 != null && this.route1 != "")
            {
                if (c.IsIP(this.route1))
                {
                    this.route1_formated = c.formatIP(this.route1);
                }
                else
                {
                    this.err = "隧道2对端私网地址格式错误";
                    return false;
                }
            }
            return true;
        }
        public Dictionary<string, string> getLoopBack(string source)
        {
            Common c = new Common();
            System.Collections.ArrayList LoopBacks = c.getLoopBacks();
            foreach (Dictionary<string, string> dic in LoopBacks)
            {
                string ipaddress = "";
                if (dic.TryGetValue("ipaddress", out ipaddress))
                {
                    if (ipaddress.ToString() == source)
                    {
                        return dic;
                    }
                }
            }
            return null;
        }
        public string getScript()
        {
            if (this.validate())
            {
                string script = "sys\r\n";
                script += "ip vpn-instance vpn." + this.vpn_name + "\r\n";
                script += " route-distinguisher 200:" + this.id.ToString() + "\r\n";
                script += "quit\r\n\r\n";
                script += "interface Tunnel" + this.tunnel_id + "\r\n";
                script += " mtu 1500\r\n";
                script += " description To-vpn." + this.vpn_name + "\r\n";
                script += " ip binding vpn-instance vpn." + this.vpn_name + "\r\n";
                script += " ip address " + this.ipaddress_formated + "\r\n";
                script += " tunnel-protocol gre\r\n";
                script += " source " + this.source_name + "\r\n";
                script += " destination " + this.destination_formated + "\r\n";
                script += "quit\r\n";

                if (this.tunnel_id1 != null && this.tunnel_id1 != "")
                {
                    script += "\r\n";
                    script += "interface Tunnel" + this.tunnel_id1 + "\r\n";
                    script += " mtu 1500\r\n";
                    script += " description To-vpn." + this.vpn_name + "\r\n";
                    script += " ip binding vpn-instance vpn." + this.vpn_name + "\r\n";
                    script += " ip address " + this.ipaddress1_formated + "\r\n";
                    script += " tunnel-protocol gre\r\n";
                    script += " source " + this.source_name1 + "\r\n";
                    script += " destination " + this.destination1_formated + "\r\n";
                    script += "quit\r\n";

                }

                return script;
            }
            return null;
        }
    }
    public class ModelVPN
    {
        public static VPN Get(int id)
        {
            VPN a = new VPN();
            string sqlStr = "SELECT * FROM [VPN] WHERE ID=" + id;
            OleDbDataReader dr = DB.dataReader(sqlStr);
            if (dr.Read())
            {
                a.id = id;
                a.vpn_name = dr["vpn_name"].ToString();
                a.source = dr["source"].ToString();
                a.destination = dr["destination"].ToString();
                a.ipaddress = dr["ipaddress"].ToString();
                a.route = dr["route"].ToString();
                a.source1 = dr["source1"].ToString();
                a.destination1 = dr["destination1"].ToString();
                a.ipaddress1 = dr["ipaddress1"].ToString();
                a.route1 = dr["route1"].ToString();
                a.memo = dr["memo"].ToString();
            }
            dr.Close();
            a.is_modified = false;
            return a;
        }
    }

}
