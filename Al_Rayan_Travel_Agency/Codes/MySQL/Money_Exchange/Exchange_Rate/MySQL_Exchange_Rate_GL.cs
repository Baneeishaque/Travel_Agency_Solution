using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL.Exchange_Rate
{
    class MySQL_Exchange_Rate_GL
    {
        MySQL_Exchange_Rate_DL MySQL_ExRDL = new MySQL_Exchange_Rate_DL();

        public string new_current_rate { get; set; }
        public string insert_date { get; set; }
        public string new_alterator { get; set; }
        
        public bool update_Exchange_Rate()
        {
            return MySQL_ExRDL.update_Exchange_Rate(this);
        }
    }
}
