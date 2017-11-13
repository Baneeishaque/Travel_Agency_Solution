using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Travel_Agency_Soution.Codes.MySQL
{
    class MySQL_Login_DL 
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        DataTable dt = new DataTable();
        public bool login(string username, string password)
        {
            bool login_result = false;
           
                dt = db.GetTable("SELECT `iduser` FROM `alrayan`.`user` WHERE username='" + username + "' AND `password`='" + password + "';");
                if (dt.Rows.Count > 0)
                {
                    login_result = true;
                }
                else
                {
                    login_result = false;
                }
           
            return login_result;
        }
    }
}
