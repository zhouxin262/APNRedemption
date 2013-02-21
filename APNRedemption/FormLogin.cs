using DAL;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace APNRedemption
{
    public partial class FormLogin : Form
    {
        public int user_id;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void tb_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        public void login()
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            string sqlStr = "SELECT id, usertype FROM [User] WHERE [username]='" + username + "' AND [password]='" + password + "'";
            OleDbDataReader dr = DB.dataReader(sqlStr);
            if (dr.Read())
            {
                int current_user_id = Int16.Parse(dr[0].ToString());
                string usertype = dr[1].ToString();
                dr.Close();
                if (usertype == "admin")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.user_id = current_user_id;
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                dr.Close();
                MessageBox.Show("账号或密码错误！");
                this.DialogResult = DialogResult.Retry;
            }
            
        }
    }
}
