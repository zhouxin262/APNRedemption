using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DAL;
using Utils;

namespace Models
{
    public class LoopBack
    {
        public int id { get; set; }
        public string loopback_name { get; set; }
        public string loopback_discription { get; set; }
        public string loopback_ipaddress { get; set; }
        public string loopback_target_board { get; set; }
        public string loopback_binding { get; set; }
                

        public void save()
        {
            string insertSQL = "INSERT INTO LoopBack(loopback_name, loopback_discription, loopback_ipaddress, loopback_target_board, loopback_binding)" +
                " VALUES(@loopback_name, @loopback_discription, @loopback_ipaddress, @loopback_target_board, @loopback_binding)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = insertSQL;
            cmd.Parameters.AddWithValue("@loopback_name", this.loopback_name);
            cmd.Parameters.AddWithValue("@loopback_discription", this.loopback_discription);
            cmd.Parameters.AddWithValue("@loopback_ipaddress", this.loopback_ipaddress);
            cmd.Parameters.AddWithValue("@loopback_target_board", this.loopback_target_board);
            cmd.Parameters.AddWithValue("@loopback_binding", this.loopback_binding);
            DB.excuteSql(cmd);
        }
        public void delete()
        {
            string deleteSql = "DELETE from apn WHERE ID=@id";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = deleteSql;
            cmd.Parameters.AddWithValue("@id", this.id);
            DB.excuteSql(cmd);
        }
    }
    public class ModelLoopBack
    {
        public static LoopBack Get(int id)
        {
            LoopBack a = new LoopBack();
            string sqlStr = "SELECT * FROM [LoopBack] WHERE ID=" + id;
            OleDbDataReader dr = DB.dataReader(sqlStr);
            if (dr.Read())
            {
                a.id = id;
                a.loopback_name = dr["loopback_name"].ToString();
                a.loopback_discription = dr["loopback_discription"].ToString();
                a.loopback_ipaddress = dr["loopback_ipaddress"].ToString();
                a.loopback_target_board = dr["loopback_target_board"].ToString();
                a.loopback_binding = dr["loopback_binding"].ToString();
            }
            dr.Close();
            return a;
        }
        public static void truncate()
        {
            string sqlStr = "DELETE FROM LoopBack";
            DB.excuteSql(sqlStr);
        }
    }
}
