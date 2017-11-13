using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Forms.Money_Exchange.Send_MOney;
using Travel_Agency_Soution.Forms.Money_Exchange;
using Aryavidyashala_Vehicle_Management_System;

namespace Travel_Agency_Soution.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Receive_Money().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Receive_Money().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Visa_Issue().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Ticket_Isuue_One_Way().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Collection().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Balance_Sheet().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Profit().Show();
            this.Hide();
        }
    }
}
