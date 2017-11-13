using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL.Travels
{
    class MySQL_Ticket_One_GL
    {
        MySQL_Ticket_One_DL MySQL_TODL = new MySQL_Ticket_One_DL();
        public string airline { get; set; }

        public string new_date { get; set; }

        public string new_connection { get; set; }

        public string date_time { get; set; }

        public string new_from { get; set; }

        public string new_to { get; set; }

        public string new_class { get; set; }

        public string pnr { get; set; }

        public string issue { get; set; }

        public string amount { get; set; }

        public string commision { get; set; }

        public string total { get; set; }

        public string id_client { get; set; }

        public bool insert_Ticket_one()
        {
            return MySQL_TODL.insert_ticket_one(this);
        }

       
    }
}
