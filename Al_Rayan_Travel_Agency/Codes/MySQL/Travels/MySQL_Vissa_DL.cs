using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Travel_Agency_Soution.Codes.MySQL.Travels
{
    class MySQL_Vissa_DL : MySQL_DB_Handler
    {
        public bool insert_Vissa(MySQL_Vissa_GL MySQL_VGL)
        {
            open_SQL_Connection();

            MySQL_Transaction = MySQL_Connection.BeginTransaction();
            MySQL_Command = new MySqlCommand();
            MySQL_Command.Transaction = MySQL_Transaction;
            MySQL_Command.Connection = MySQL_Connection;
            MySQL_Command.CommandType = CommandType.StoredProcedure;

            try
            {

                MySQL_Command.CommandText = "vissa";

                //MySQL_Command.Parameters.AddWithValue("@flag", 2);
                //MySQL_Command.Parameters["@flag"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@vissa_type", MySQL_VGL.vissa_type);
                MySQL_Command.Parameters["@vissa_type"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@permit_number", MySQL_VGL.permit_number);
                MySQL_Command.Parameters["@permit_number"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@issue_date", MySQL_VGL.issue_date);
                MySQL_Command.Parameters["@issue_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@new_date", MySQL_VGL.new_date);
                MySQL_Command.Parameters["@new_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@issue_place", MySQL_VGL.issue_place);
                MySQL_Command.Parameters["@issue_place"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@valid_till", MySQL_VGL.valid_till);
                MySQL_Command.Parameters["@valid_till"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@emigration_date", MySQL_VGL.emigration_date);
                MySQL_Command.Parameters["@emigration_date"].Direction = ParameterDirection.Input;


                MySQL_Command.Parameters.AddWithValue("@expiry_date", MySQL_VGL.expiry_date);
                MySQL_Command.Parameters["@expiry_date"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@amount", MySQL_VGL.amount);
                MySQL_Command.Parameters["@amount"].Direction = ParameterDirection.Input;


                MySQL_Command.Parameters.AddWithValue("@commision", MySQL_VGL.commision);
                MySQL_Command.Parameters["@commision"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@total_amount", MySQL_VGL.total_amount);
                MySQL_Command.Parameters["@total_amount"].Direction = ParameterDirection.Input;

                MySQL_Command.Parameters.AddWithValue("@id_client", MySQL_VGL.id_client);
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
