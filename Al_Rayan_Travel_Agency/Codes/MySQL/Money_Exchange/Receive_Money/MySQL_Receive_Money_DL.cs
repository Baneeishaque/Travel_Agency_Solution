using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;
namespace Travel_Agency_Soution.Codes.MySQL.Money.Receive_Money
{
    class MySQL_Receive_Money_DL : MySQL_DB_Handler
    {
        public bool insert_Receive_Money(MySQL_Receive_Money_GL MySQL_RMGL)
        {
            open_SQL_Connection();

            MySQL_Transaction = MySQL_Connection.BeginTransaction();
            MySQL_Command = new MySqlCommand();
            MySQL_Command.Transaction = MySQL_Transaction;
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            try
            {

                MySQL_Command.CommandText = "receive_money";
                //MySQL_Command.Parameters.AddWithValue("@flag", 2);
                //MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@new_date", MySQL_RMGL.new_date);
                MySQL_Command.Parameters["@new_date"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@rate", MySQL_RMGL.rate);
                MySQL_Command.Parameters["@rate"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@agency_rate", MySQL_RMGL.agency_rate);
                MySQL_Command.Parameters["@agency_rate"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@inr", MySQL_RMGL.inr);
                MySQL_Command.Parameters["@inr"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@deliver_aed", MySQL_RMGL.deliver_aed);
                MySQL_Command.Parameters["@deliver_aed"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@actual_aed", MySQL_RMGL.actual_aed);
                MySQL_Command.Parameters["@actual_aed"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@benefit", MySQL_RMGL.benefit);
                MySQL_Command.Parameters["@benefit"].Direction = ParameterDirection.Input;


                MySQL_Command.Parameters.AddWithValue("@id_client", MySQL_RMGL.id_client);
                MySQL_Command.Parameters["@id_client"].Direction = ParameterDirection.Input;






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
