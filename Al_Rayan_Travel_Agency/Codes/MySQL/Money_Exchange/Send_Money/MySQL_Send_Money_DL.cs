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
    class MySQL_Send_Money_DL : MySQL_DB_Handler
    {
        public bool insert_Send_Money(MySQL_Send_Money_GL MySQL_SMGL)
        {
            open_SQL_Connection();

            MySQL_Transaction = MySQL_Connection.BeginTransaction();
            MySQL_Command = new MySqlCommand();
            MySQL_Command.Transaction = MySQL_Transaction;
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            try
            {

                MySQL_Command.CommandText = "send_money";
                //MySQL_Command.Parameters.AddWithValue("@flag", 2);
                //MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@new_date", MySQL_SMGL.new_date);
                MySQL_Command.Parameters["@new_date"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@rate", MySQL_SMGL.rate);
                MySQL_Command.Parameters["@rate"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@aed", MySQL_SMGL.aed);
                MySQL_Command.Parameters["@aed"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@inr", MySQL_SMGL.inr);
                MySQL_Command.Parameters["@inr"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@benefit", MySQL_SMGL.benefit);
                MySQL_Command.Parameters["@benefit"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@total_aed", MySQL_SMGL.total_aed);
                MySQL_Command.Parameters["@total_aed"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@advance1", MySQL_SMGL.advance1);
                MySQL_Command.Parameters["@advance1"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@advance2", MySQL_SMGL.advance2);
                MySQL_Command.Parameters["@advance2"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@advance3", MySQL_SMGL.advance3);
                MySQL_Command.Parameters["@advance3"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@balance", MySQL_SMGL.balance);
                MySQL_Command.Parameters["@balance"].Direction = ParameterDirection.Input;
                MySQL_Command.Parameters.AddWithValue("@advance1_date", MySQL_SMGL.advance1_date);
                MySQL_Command.Parameters["@advance1_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@advance2_date", MySQL_SMGL.advance2_date);
                MySQL_Command.Parameters["@advance2_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@advance3_date", MySQL_SMGL.advance3_date);
                MySQL_Command.Parameters["@advance3_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@id_client", MySQL_SMGL.id_client);
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
