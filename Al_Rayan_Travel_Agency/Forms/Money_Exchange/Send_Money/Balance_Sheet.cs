using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Codes.MySQL.Client.Money_Client;

namespace Travel_Agency_Soution.Forms.Money_Exchange.Send_MOney
{
    public partial class Balance_Sheet : Form
    {
        MySQL_Money_Client_DL MySQL_MCDL = new MySQL_Money_Client_DL();
        public Balance_Sheet()
        {
            InitializeComponent();
            dataGridView_sheet.DataSource = MySQL_MCDL.Return_Money_Client_Table(4, "0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
