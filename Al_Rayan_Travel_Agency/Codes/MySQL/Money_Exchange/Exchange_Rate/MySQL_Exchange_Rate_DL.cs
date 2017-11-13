using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Travel_Agency_Soution.Codes.MySQL.Exchange_Rate
{
    class MySQL_Exchange_Rate_DL : MySQL_DB_Handler
    {
        public DataTable Return_Current_Rate_Table()
        {
            open_SQL_Connection();

            MySQL_Command = new MySqlCommand();
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            MySQL_Command.CommandText = "exchange_rate";
            MySQL_Command.Parameters.AddWithValue("@flag", 1);
            MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
            MySQL_Command.Parameters.AddWithValue("@new_current_rate", 0);
            MySQL_Command.Parameters["@new_current_rate"].Direction = ParameterDirection.Input;
            MySQL_Command.Parameters.AddWithValue("@insert_date", "");
            MySQL_Command.Parameters["@insert_date"].Direction = ParameterDirection.Input;
            MySQL_Command.Parameters.AddWithValue("@new_alterator", "");
            MySQL_Command.Parameters["@new_alterator"].Direction = ParameterDirection.Input;
            return General_ReturnDataTable();

        }

        public bool update_Exchange_Rate(MySQL_Exchange_Rate_GL MySQL_ExRGL)
        {
            open_SQL_Connection();

           
            MySQL_Transaction = MySQL_Connection.BeginTransaction();
            MySQL_Command = new MySqlCommand(); 
            MySQL_Command.Transaction = MySQL_Transaction;
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            try
            {
                //MessageBox.Show(MySQL_ExRGL.new_alterator);

                MySQL_Command.CommandText = "exchange_rate";
                MySQL_Command.Parameters.AddWithValue("@flag", 2);
                MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@new_current_rate", MySQL_ExRGL.new_current_rate);
                MySQL_Command.Parameters["@new_current_rate"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@insert_date", MySQL_ExRGL.insert_date);
                MySQL_Command.Parameters["@insert_date"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@new_alterator", MySQL_ExRGL.new_alterator);
                MySQL_Command.Parameters["@new_alterator"].Direction = ParameterDirection.Input;




                MySQL_Command.ExecuteNonQuery();

                MySQL_Transaction.Commit();
                return true;
            }
            catch (Exception exception)
            {
                ((DbTransaction)MySQL_Transaction).Rollback();
                MessageBox.Show("Error while saving .. Please try again, Reason : " + exception.Message);

                return false;
            }

           
         

        }
    }
}
