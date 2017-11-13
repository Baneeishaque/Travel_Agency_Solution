using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Net;

using System.Management;




using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms; 
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

namespace ProBunk

{
    
    class Sqlconnector
    {
        public String ProductName { get; set; }
        public string GetProductName()
        {
            return ProductName = "ProsysPwd";
        }


        public void TabOrderWithColor(KeyEventArgs e,Control r)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
              

            }
        }
        public void TabOrder(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
               // ChangeTextBoxColorWhenFocused(r, Color.YellowGreen);

            }
        }
        public void SetToolTip (Control rt,ToolTip Tt,string Text)
    {
        //Tt.SetToolTip(rt, Text);
        //Tt.Show(Text, rt);

    }
        public void MakeRoundForm(Form formname, int Radius)
        {
            GraphicsPath path = new GraphicsPath();
            GraphicsPath graphicsPath1 = path;
            RectangleF rectangleF = new RectangleF(0.0f, 0.0f, (float)Radius, (float)Radius);
            RectangleF rect1 = rectangleF;
            double num1 = 180.0;
            double num2 = 90.0;
            graphicsPath1.AddArc(rect1, (float)num1, (float)num2);
            GraphicsPath graphicsPath2 = path;
            PointF pointF1 = new PointF((float)Radius, 0.0f);
            PointF pt1_1 = pointF1;
            PointF pointF2 = new PointF((float)checked(formname.Width - Radius), 0.0f);
            PointF pt2_1 = pointF2;
            graphicsPath2.AddLine(pt1_1, pt2_1);
            GraphicsPath graphicsPath3 = path;
            rectangleF = new RectangleF((float)checked(formname.Width - Radius), 0.0f, (float)Radius, (float)Radius);
            RectangleF rect2 = rectangleF;
            double num3 = 270.0;
            double num4 = 90.0;
            graphicsPath3.AddArc(rect2, (float)num3, (float)num4);
            GraphicsPath graphicsPath4 = path;
            pointF2 = new PointF((float)formname.Width, (float)Radius);
            PointF pt1_2 = pointF2;
            pointF1 = new PointF((float)formname.Width, (float)checked(formname.Height - Radius));
            PointF pt2_2 = pointF1;
            graphicsPath4.AddLine(pt1_2, pt2_2);
            GraphicsPath graphicsPath5 = path;
            rectangleF = new RectangleF((float)checked(formname.Width - Radius), (float)checked(formname.Height - Radius), (float)Radius, (float)Radius);
            RectangleF rect3 = rectangleF;
            double num5 = 0.0;
            double num6 = 90.0;
            graphicsPath5.AddArc(rect3, (float)num5, (float)num6);
            GraphicsPath graphicsPath6 = path;
            pointF2 = new PointF((float)checked(formname.Width - Radius), (float)formname.Height);
            PointF pt1_3 = pointF2;
            pointF1 = new PointF((float)Radius, (float)formname.Height);
            PointF pt2_3 = pointF1;
            graphicsPath6.AddLine(pt1_3, pt2_3);
            GraphicsPath graphicsPath7 = path;
            rectangleF = new RectangleF(0.0f, (float)checked(formname.Height - Radius), (float)Radius, (float)Radius);
            RectangleF rect4 = rectangleF;
            double num7 = 90.0;
            double num8 = 90.0;
            graphicsPath7.AddArc(rect4, (float)num7, (float)num8);
            GraphicsPath graphicsPath8 = path;
            pointF2 = new PointF(0.0f, (float)checked(formname.Height - Radius));
            PointF pt1_4 = pointF2;
            pointF1 = new PointF(0.0f, (float)Radius);
            PointF pt2_4 = pointF1;
            graphicsPath8.AddLine(pt1_4, pt2_4);
            formname.Region = new Region(path);
        }

        public void ChangeTextBoxColorWhenFocused(Control t, Color rr)
        {
            if (t is TextBox || t is ComboBox)
            {
                t.BackColor = rr;
                t.Focus();
            }
            

        }


        public void ChangeTextBoxBackColor(TextBox t,Color rr)
        {
            if (t.Text != "")
            {
                t.BackColor = rr;
            }
            else
            {
                t.BackColor = Color.White;
            }
        }
      



        public SqlConnection CON;
        public SqlCommand CMD;
        public static bool refreshnozle = false;
        
        public bool refres { get; set; }
       
        public void Refresnoz()
        {

            refreshnozle = true;

           
 
        }
        public void StopNozleFResh()
        {
            refreshnozle = false;

            
        }
        public bool CheckRefreshStatus()
        {
            if (refreshnozle == true)
            {
                return refreshnozle;
            }
            else
            {
                return refreshnozle;
            }
        }


        public void OpenConnection()
        {
           
            ProductName = "ProCook";
            
            string VARCON = ConfigurationSettings.AppSettings["VARCON"];
           //VARCON = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "ProConstrcution.mdf" + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
        //   CON = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\ProConstrcution.mdf" + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
           CON = new SqlConnection(VARCON);
            if (CON.State == ConnectionState.Open)
            {
                CON.Close();
            }
            else
            {
                CON.Open();
            }
            
        }
        public void CloseConnection()
        {
            //if (CON.State == ConnectionState.Open)
            //{
            //    CON.Close();
            //}
        }
        
        public void FillListBox(ListBox Lb,DataTable dt,string Diplaymember,string ValueMaember)
        {
            Lb.DisplayMember = Diplaymember;
            Lb.ValueMember = ValueMaember;

            Lb.DataSource = dt;
            

        }
        public void ClearTextFields(TextBox[] txtBoxes)
        {
            for (int i = 0; i < txtBoxes.Length; i++)
            {
                txtBoxes[i].Text = "";
            }

        }
        public void ChangeFocus(System.Windows.Forms.Control TxtTarget, KeyEventArgs e)
        {
           // TxtTarget.BackColor = Color.White;


            if (e.KeyCode == Keys.Enter)
            {


                TxtTarget.Focus();
              


                ChangeTextBoxColorWhenFocused(TxtTarget, Color.YellowGreen);

            }
            else
            {
 
            }

        }
        public string ConvertToXml(DataTable dt)
        {
            try
            {
                string result;
                dt.TableName = "Mytable";
                using (StringWriter sw = new StringWriter())
                {
                    dt.WriteXml(sw);
                    result = sw.ToString();

                }
                result = result.Replace("NewDataSet", "DocumentElement");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ReturnDataTable(int flag)
        {
            try
            {
                CMD.Parameters.Add("@flag", SqlDbType.BigInt).Value = flag;
                DataTable DT = new DataTable();
                SqlDataAdapter OBJADAPTER = new SqlDataAdapter(CMD);
                OBJADAPTER.Fill(DT);
                return DT;
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show("Exception"+ee.ToString());
                
                return null;
            }

        }

        public DataSet ReturnDataSet(int flag)
        {
            CMD.Parameters.Add("@flag", SqlDbType.BigInt).Value = flag;
            DataSet DS = new DataSet();
            SqlDataAdapter OBJADAPTER = new SqlDataAdapter(CMD);
            OBJADAPTER.Fill(DS);
            return DS;
        }


        public void OnlyNumeric(TextBox txt, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == '.' && !txt.Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }
        public void DigitOnly(TextBox txt, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }

        public int SerelelNo = 1;
        public void GenerateSerielNumberOnGrid(DataGridView dgv,string ColumnHeader)
        {
            SerelelNo = 1;
            foreach (DataGridViewRow  R in dgv.Rows)
            {
                dgv.Refresh();
                R.Cells[ColumnHeader].Value = SerelelNo;
                SerelelNo++;
                
            }
            SerelelNo = 1;
            

        }

        public void FillComboBox(ComboBox CMB,string DisplayMember,string ValueMember,DataTable DTCOMBO)
        {

            try
            {
                CMB.DisplayMember = DisplayMember;
                CMB.ValueMember = ValueMember;
                if (DTCOMBO.Rows.Count > 0)
                {
                    CMB.DataSource = DTCOMBO;
                    CMB.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error While ComboFilling");
            }

 
        }
        public void ClearTextFields(TextBox TXT)
        {
            TXT.Text = "";
        }
        public void ClearGridValueRows(DataGridView DGV)
        {
            if (DGV.Rows.Count > 0)
            {
                DataTable DT = (DataTable)DGV.DataSource;
                DT.Rows.Clear();
                DT.AcceptChanges();
                DGV.DataSource = DT;
            }
 
        }
        public void ClearCombobox(ComboBox cmb)
        {
            try
            {
                if (cmb.DataSource != null)
                {
                    DataTable dtcombo = (DataTable)cmb.DataSource;
                    dtcombo.Rows.Clear();
                    dtcombo.AcceptChanges();
                    cmb.DataSource = dtcombo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ErrorWhile Clearing ComboBox");
            }
        }
        public void UncheckCheckBox(CheckBox CHK)
        {
            if (CHK.Checked == true)
            {
                CHK.Checked = false;
            }
        }
        public void RemoveControlsFromFlowLayout(FlowLayoutPanel f)
        {
            foreach (Control r in f.Controls)
            {
                r.Hide();
            }
        }


    }
}
