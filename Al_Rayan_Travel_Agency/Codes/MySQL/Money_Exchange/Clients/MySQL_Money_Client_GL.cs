using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL.Client.Money_Client
{
    class MySQL_Money_Client_GL
    {
        MySQL_Money_Client_DL MySQL_MCDL = new MySQL_Money_Client_DL();

        public string client_name { get; set; }
        public string id_client { get; set; }
        public string client_address { get; set; }
        public string client_mobile { get; set; }

        public bool insert_Monay_Client()
        {
            return MySQL_MCDL.insert_Monay_Client(this);
        }

    }
}
