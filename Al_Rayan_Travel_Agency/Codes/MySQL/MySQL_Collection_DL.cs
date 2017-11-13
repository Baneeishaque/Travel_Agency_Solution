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
    class MySQL_Collection_DL : MySQL_DB_Handler
    {
        public DataTable Return_Collection_Table(int flag)
        {
            open_SQL_Connection();

            MySQL_Command = new MySqlCommand();
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            MySQL_Command.CommandText = "get_collection";
            MySQL_Command.Parameters.AddWithValue("@flag", flag);
            MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
            //MySQL_Command.Parameters.AddWithValue("@search_id", 0);
            //MySQL_Command.Parameters["@search_id"].Direction = ParameterDirection.Input;

            return General_ReturnDataTable();

        }
    }
}
