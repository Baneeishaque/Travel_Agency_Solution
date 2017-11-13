using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL.Money.Receive_Money
{
    class MySQL_Receive_Money_GL
    {
        MySQL_Receive_Money_DL MySQL_RMDL = new MySQL_Receive_Money_DL();

        public string new_date { get; set; }

        public string rate { get; set; }

        public string inr { get; set; }

        public string deliver_aed { get; set; }

        public string benefit { get; set; }

        public string id_client { get; set; }

        public bool insert_Receive_Money()
        {
            return MySQL_RMDL.insert_Receive_Money(this);
        }

        public string agency_rate { get; set; }

        public string actual_aed { get; set; }
    }
}
