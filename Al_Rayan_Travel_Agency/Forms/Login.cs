using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using Travel_Agency_Soution.Forms;
using Aryavidyashala_Vehicle_Management_System;
using Common_Programming_Tasks;
using Travel_Agency_Soution.Codes.MySQL; 

namespace ProBunk
{
    public partial class Login :Form
    {
        public static string person = "";
        Sqlconnector OBJSQL = new Sqlconnector();
        MySQL_Login_DL MLDL = new MySQL_Login_DL();
        
        public Login()
        {
            InitializeComponent();
            label9.Hide();
            comboBox_section.SelectedIndex = 0;
        }

       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
           OBJSQL.MakeRoundForm((Form) this, 50);
            TimerProgress.Start();
        }
        public void ClearFileds()
        {
            TextBox[] ss = { textbox_UserName, textbox_Password };
            OBJSQL.ClearTextFields(ss);
        }
        
        public void BeginProgress()
        {
            panel1.Visible = false;
            PrgrssBar.Value = PrgrssBar.Value + 1;
            

            label2.Text = (PrgrssBar.Value.ToString() + "%...");


            if (PrgrssBar.Value <= 30)
                label1.Text = "Initializing Al Rayan.....";
            else if (PrgrssBar.Value <= 40)
                label1.Text = "Checking Validity .....";
            else if (PrgrssBar.Value <= 45)
                label1.Text = "Checking Licence .....";
            else if (PrgrssBar.Value <= 50)
                label1.Text = "Loading Files .....";

            else if (PrgrssBar.Value <= 70)
                label1.Text = "Loading database ....";
            else if (PrgrssBar.Value <= 100)
                label1.Text = "Please wait ....";
            if (PrgrssBar.Value != 100)
                return;
            TimerProgress.Dispose();
            TimerProgress.Enabled = false;
            PrgrssBar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            
            panel1.Visible = true;
           
        }
        

        private void FrmLogin_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseDown = false;
            
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.IsMouseDown)
                return;
            Point point = this.PointToScreen(new Point(e.X, e.Y));
            this.Location = new Point(checked(point.X - this.startPoint.X), checked(point.Y - this.startPoint.Y));  
        }

        private void FrmLogin_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmLogin_DragLeave(object sender, EventArgs e)
        {
           
        }
        public bool r = false;

        public Point startPoint;
        public bool IsMouseDown = false;
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.IsMouseDown = true;
        }

        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            BeginProgress();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Validation()
        {

            err.Dispose();

            return isemptyg(new Control[2] { textbox_UserName, textbox_Password });

        }



        ErrorProvider err = new ErrorProvider();

        bool isemptyg(System.Windows.Forms.Control[] c)
        {
            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Text.Equals(""))
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            return ret;
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (Validation())
            {


                if (comboBox_section.SelectedItem.ToString().Equals(""))
                {

                    err.SetError(comboBox_section, "Select Section");
                    comboBox_section.Focus();
                }
                else
                {
                    if (MLDL.login(textbox_UserName.Text,textbox_Password.Text))
                    {
                        Common_Tasks.nullify(new Control[] { textbox_UserName, textbox_Password });
                        Common_Tasks.hide(new Control[] { label9 });
                        if (comboBox_section.SelectedIndex == 0)
                        {
                            person = textbox_UserName.Text;
                            new Travels_Home().ShowDialog();
                        }
                        else if (comboBox_section.SelectedIndex == 1)
                        {
                            new Exchange_Home().ShowDialog();
                        }
                        
                    }
                    else
                    {
                        Common_Tasks.show(new Control[] { label9 });
                    }
                }
               
                
                
            }
            
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            
                OBJSQL.ChangeTextBoxBackColor(textbox_UserName,Color.GreenYellow);
            
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            
                OBJSQL.ChangeTextBoxBackColor(textbox_Password,Color.GreenYellow);

        }

    }
}
