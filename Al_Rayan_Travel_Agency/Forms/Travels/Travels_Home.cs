using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multi_DB_Handler_Solution.Codes.DB_Handler;
using Al_Rayan_Travel_Agency.Forms.Travels.Clients;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Travels_Home : Form
    {
        MySQL_DB_Handler db = new MySQL_DB_Handler();
        
        public Travels_Home()
        {
            InitializeComponent();
         
          


        }

       


        

        private void button_notifications_Click(object sender, EventArgs e)
        {
            //new Notifications().ShowDialog();
        }

        

        private void button_trips_Click(object sender, EventArgs e)
        {
            //new Trips().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //new Batha_Assign().ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           // Program.pi.Dispose();
        }

        

       

        private void button_vehicle_Click(object sender, EventArgs e)
        {
           // new Vehicle_Manipulation().ShowDialog();
        }

        private void button_batha_Click(object sender, EventArgs e)
        {
            new About_Us().ShowDialog();
        }

       
        
        private void button_trip_Click(object sender, EventArgs e)
        {
           // new Trip_Manipulation().ShowDialog();
        }

        private void button_petrol_Click(object sender, EventArgs e)
        {
            //new Petrol_Bank_Manipulation().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Collection().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Profit().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Travel_Clients().ShowDialog();
        }

       

       
       
        

        

       

        
    }
}
