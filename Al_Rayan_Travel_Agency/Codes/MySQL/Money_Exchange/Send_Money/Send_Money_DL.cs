using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Multi_DB_Handler_Solution.Codes.DB_Handler;

namespace Al_Rayan_Travel_Agency.Codes.MySQL.Money_Exchange.Send_Money
{
    class Send_Money_DL
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();

        public double check_balance(String id)
        {
            if (db.get_single_field_row_count_with_condition("balance", "send_money", "id_client", id) == 0)
            {
                return -1;
            }
            else
            {
                return Double.Parse(db.GetValue("SELECT balance FROM send_money WHERE (id_client = " + id + ")"));
            }
        }
    }
}
