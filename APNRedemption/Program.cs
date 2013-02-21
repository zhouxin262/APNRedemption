using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APNRedemption
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdmin());
            

            //while (true)
            //{
            //    FormLogin fl = new FormLogin();
            //    fl.ShowDialog();
            //    if (fl.DialogResult == DialogResult.Yes)
            //    {
            //        FormUser fu = new FormUser();
            //        fu.current_user_id = fl.user_id;
            //        Application.Run(fu);
            //        break;
            //    }
            //    else if (fl.DialogResult == DialogResult.OK)
            //    {
            //        Application.Run(new FormAdmin());
            //        break;
            //    }
            //    else if (fl.DialogResult == DialogResult.Cancel)
            //    {
            //        Application.Exit();
            //        break;
            //    }
            //    else
            //    {
            //    }
            //}
        }
    }
}
