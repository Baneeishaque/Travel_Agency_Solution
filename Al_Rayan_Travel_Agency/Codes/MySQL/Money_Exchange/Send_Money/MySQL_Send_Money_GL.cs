using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL
{
    class MySQL_Send_Money_GL
    {
        MySQL_Send_Money_DL MySQL_SMDL = new MySQL_Send_Money_DL();

        public string new_date { get; set; }
        public string rate { get; set; }
        public string aed { get; set; }

        public string inr { get; set; }
        public string benefit { get; set; }
        public string total_aed { get; set; }
        public string advance1 { get; set; }
        public string advance2 { get; set; }
        public string advance3 { get; set; }
        public string balance { get; set; }
        public string advance1_date { get; set; }
        public string advance2_date { get; set; }

        public string advance3_date { get; set; }
        public string id_client { get; set; }

        
        public bool insert_Send_Money()
        {
            return MySQL_SMDL.insert_Send_Money(this);
        }
        
    }
}
