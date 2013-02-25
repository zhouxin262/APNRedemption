using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DAL;
using Utils;

namespace Models
{
    public class APN
    {
        public int id { get; set; }
        public string apn_name { get; set; }
        public string sim_ip { get; set; }
        public string is_static { get; set; }
        public string serverip { get; set; }
        public string ggsn { get; set; }
        public int vpn1_id { get; set; }
        public int vpn2_id { get; set; }
        public string contact { get; set; }
        public string ggsn_gnif { get; set; }
        public string tunnel_name { get; set; }
        public string memo { get; set; }

        // no db
        public bool is_modified { get; set; }
        public VPN vpn1 { get; set; }

        // validate
        public string ggsn_gnif_formated { get; set; }
        public string sim_ip_pool { get; set; }
        public string serverip_formated { get; set; }
        public string sim_ip_formated { get; set; }
        public string err { get; set; }


        public void save()
        {
            if (this.id > 0)
            {
                string updateSql = "UPDATE APN SET apn_name=@apn_name, sim_ip=@sim_ip, is_static=@is_static, serverip=@serverip, " +
                    "ggsn=@ggsn, vpn1_id=@vpn1_id, vpn2_id=@vpn2_id, contact=@contact, ggsn_gnif=@ggsn_gnif, " +
                    "tunnel_name=@tunnel_name, [memo]=@memo WHERE id=@id";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = updateSql;
                cmd.Parameters.AddWithValue("@apn_name", this.apn_name);
                cmd.Parameters.AddWithValue("@sim_ip", this.sim_ip);
                cmd.Parameters.AddWithValue("@is_static", this.is_static);
                cmd.Parameters.AddWithValue("@serverip", this.serverip);
                cmd.Parameters.AddWithValue("@ggsn", this.ggsn);
                cmd.Parameters.AddWithValue("@vpn1_id", this.vpn1_id);
                cmd.Parameters.AddWithValue("@vpn2_id", this.vpn2_id);
                cmd.Parameters.AddWithValue("@contact", this.contact);
                cmd.Parameters.AddWithValue("@ggsn_gnif", this.ggsn_gnif);
                cmd.Parameters.AddWithValue("@tunnel_name", this.tunnel_name);
                cmd.Parameters.AddWithValue("@memo", this.memo);
                cmd.Parameters.AddWithValue("@id", this.id);
                DB.excuteSql(cmd);
            }
            else
            {
                string insertSql = "INSERT INTO APN(apn_name, sim_ip, is_static, serverip, ggsn, vpn1_id, vpn2_id, contact, ggsn_gnif, tunnel_name, [memo])" +
                " VALUES(@apn_name, @sim_ip, @is_static, @serverip, @ggsn, @vpn1_id, @vpn2_id, @contact, @ggsn_gnif, @tunnel_name, [memo])";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = insertSql;
                cmd.Parameters.AddWithValue("@apn_name", this.apn_name);
                cmd.Parameters.AddWithValue("@sim_ip", this.sim_ip);
                cmd.Parameters.AddWithValue("@is_static", this.is_static);
                cmd.Parameters.AddWithValue("@serverip", this.serverip);
                cmd.Parameters.AddWithValue("@ggsn", this.ggsn);
                cmd.Parameters.AddWithValue("@vpn1_id", this.vpn1_id);
                cmd.Parameters.AddWithValue("@vpn2_id", this.vpn2_id);
                cmd.Parameters.AddWithValue("@contact", this.contact);
                cmd.Parameters.AddWithValue("@ggsn_gnif", this.ggsn_gnif);
                cmd.Parameters.AddWithValue("@tunnel_name", this.tunnel_name);
                cmd.Parameters.AddWithValue("@memo", this.memo);
                DB.excuteSql(cmd);

            }
                       
            this.is_modified = false;
        }
        public void delete()
        {
            string deleteSql = "DELETE from apn WHERE ID=@id";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = deleteSql;
            cmd.Parameters.AddWithValue("@id", this.id);
            DB.excuteSql(cmd);
        }
        public bool validate()
        {
            Common c = new Common();
            if (c.IsIP(this.sim_ip))
            {
                this.sim_ip_pool = c.ipPool(this.sim_ip);
                this.sim_ip_formated = c.formatIP(this.sim_ip);
            }
            else
            {
                this.err = "SIM地址格式错误";
                return false;
            }
            if (c.IsIP(this.ggsn_gnif))
            {
                this.ggsn_gnif_formated = c.formatIP(this.ggsn_gnif, true);
            }
            else
            {
                this.err = "GNIF地址格式错误";
                return false;
            }
            if (c.IsIP(this.serverip))
            {
                this.serverip_formated = c.formatIP(this.serverip);
            }
            else
            {
                this.err = "服务器地址格式错误";
                return false;
            }
            return true;
        }
        public string getScript()
        {
            if (this.validate())
            {
                // 地址池
                //access-view
                // ip pool zybagps.gz local ipv4
                // vpn-instance vpn.zybagps.gz
                // section 0 172.16.140.0 172.16.140.255 static(静态时候添加static，动态的时候没有)
                // section 1 
                string script = "sys\r\naccess-view\r\n";
                script += " ip pool " + this.apn_name + " local ipv4\r\n";
                script += " vpn-instance vpn." + this.vpn1.vpn_name + "\r\n";
                if (this.is_static == "静态")
                {
                    script += " section 0 " + this.sim_ip_pool + " static\r\n";
                }
                else
                {
                    script += " section 0 " + this.sim_ip_pool + "\r\n";
                }
                script += "quit\r\n";
                script += "quit\r\n";

                //;;APN的配置: 
                //apn zybagps.gz
                // vpn-instance vpn.zybagps.gz
                // address-pool zybagps.gz
                // acl-binding direction up-in acl a_phone_user_sec  （防止手机攻击GGSN的脚本，每个APN都要配置）
                script += "\r\n";
                script += "apn " + this.apn_name + "\r\n";
                script += " vpn-instance vpn." + this.vpn1.vpn_name + "\r\n";
                script += " address-pool " + this.apn_name + "\r\n";
                script += " acl-binding direction up-in acl a_phone_user_sec\r\n";
                script += "quit\r\n";

                // 路由
                script += "ip route-static vpn-instance vpn." + this.vpn1.vpn_name + " " + this.serverip_formated + " Tunnel" + this.vpn1.tunnel_id + " description TO-" + this.vpn1.vpn_name + "-APN\r\n";
                if (this.vpn1.tunnel_id1 != null && this.vpn1.tunnel_id1 != "")
                {
                    script += "ip route-static vpn-instance vpn." + this.vpn1.vpn_name + " " + this.serverip_formated + " Tunnel" + this.vpn1.tunnel_id1 + " preference 70 description TO-" + this.vpn1.vpn_name + "-APN\r\n";
                }
                //ip route-static vpn-instance vpn.zybagps.gz 10.92.80.20 255.255.255.255 Tunnel3/1/2 description TO-zybagps.gz-APN

                // 静态 - 回程路由   
                script += "\r\n";
                if (this.is_static == "静态")
                {
                    script += "ip route-static vpn-instance vpn." + this.vpn1.vpn_name + " " + this.sim_ip_formated + " Gif" + this.vpn1.tunnel + " description TO-" + this.apn_name + ".gz-MS\r\n";
                }
                return script;
            }
            return null;
        }
        public string getDNSScript()
        {
            if (this.validate())
            {
                string apn_name = this.apn_name;
                if (this.apn_name.Substring(this.apn_name.Length - 3, 3) == ".gz")
                {
                    apn_name = this.apn_name.Substring(0, this.apn_name.Length - 3);
                }
                string script = "sys\r\n";
                script += apn_name + "\tIN\tA\t" + this.ggsn_gnif_formated + "\r\n";
                script += "quit";
                return script;
            }
            return null;
        }
        public VPN set_vpn_by_name(string vpn_name)
        {
            VPN v = ModelVPN.GetByName(vpn_name);
            this.vpn1_id = v.id; 
            return v;
        }
    }
    public class ModelAPN
    {
        public static APN Get(int id)
        {
            APN a = new APN();
            string sqlStr = "SELECT * FROM [APN] WHERE ID=" + id;
            OleDbDataReader dr = DB.dataReader(sqlStr);
            if (dr.Read())
            {
                a.id = id;
                a.apn_name = dr["apn_name"].ToString();
                a.sim_ip = dr["sim_ip"].ToString();
                a.is_static = dr["is_static"].ToString();
                a.ggsn = dr["ggsn"].ToString();
                if (dr["vpn1_id"].ToString() == "") { a.vpn1_id = 0; }
                else { a.vpn1_id = int.Parse(dr["vpn1_id"].ToString()); }
                if (dr["vpn2_id"].ToString() == "") { a.vpn2_id = 0; }
                else { a.vpn2_id = int.Parse(dr["vpn2_id"].ToString()); }
                a.contact = dr["contact"].ToString();
                a.ggsn_gnif = dr["ggsn_gnif"].ToString();
                a.serverip = dr["serverip"].ToString();
                a.tunnel_name = dr["tunnel_name"].ToString();
                a.memo = dr["memo"].ToString();
            }
            dr.Close();
            if (a.vpn1_id > 0)
            {
                a.vpn1 = ModelVPN.Get(a.vpn1_id);
                a.vpn1.validate();
            }
            a.is_modified = false;
            return a;
        }
        public static void truncate()
        {
            string sqlStr = "DELETE FROM APN";
            DB.excuteSql(sqlStr);
        }
        public static APN create_new(string apn_name)
        {
            APN a = new APN();
            a.apn_name = apn_name;
            a.sim_ip = "";
            a.is_static = "";
            a.serverip = "";
            a.ggsn = "";
            a.vpn1_id = 0;
            a.vpn2_id = 0;
            a.contact = "";
            a.ggsn_gnif = "";
            a.tunnel_name = "";
            a.memo = "";
            return a;
        }
    }
}
