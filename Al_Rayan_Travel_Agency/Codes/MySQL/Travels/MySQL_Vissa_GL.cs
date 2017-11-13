using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Agency_Soution.Codes.MySQL.Travels
{
    class MySQL_Vissa_GL
    {
        MySQL_Vissa_DL MySQL_VDL = new MySQL_Vissa_DL();

        public string vissa_type { get; set; }

        public string permit_number { get; set; }

        public string issue_date { get; set; }

        public string new_date { get; set; }

        public string issue_place { get; set; }

        public string valid_till { get; set; }

        public string emigration_date { get; set; }

        public string expiry_date { get; set; }

        public string amount { get; set; }

        public string commision { get; set; }

        public string total_amount { get; set; }

        public bool insert_Vissa()
        {
            return MySQL_VDL.insert_Vissa(this);
        }

        public string id_client { get; set; }
    }
}
