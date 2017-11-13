using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Travel_Agency_Soution.Forms;
using Travel_Agency_Soution.Forms.Money_Exchange.Send_MOney;
using Travel_Agency_Soution.Forms.Money_Exchange;
using ProBunk;
using Aryavidyashala_Vehicle_Management_System;
using Al_Rayan_Travel_Agency.Forms.Travels.Clients;

namespace Travel_Agency_Soution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Travel_Clients());
            //Application.Run(new Exchange_Home());
            //Application.Run(new Travels_Home());
            //Application.Run(new Send_Money());
            Application.Run(new Login());

        }
    }
}
