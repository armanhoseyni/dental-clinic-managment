using ChreneLib.Controls.TextBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic2.m
{
    public partial class modir_mali : Form
    {
        public modir_mali()
        {
            InitializeComponent();
        }
        m.DB_dentist_clinicEntities myDB = new m.DB_dentist_clinicEntities();
        private void modir_mali_Load(object sender, EventArgs e)
        {
            if (datatransfer1.CurrentUserRole==16)
            {
                btn_exit.Visible = true;
                btn_bargasht.Visible=false;
            }
            else
            {
                btn_exit.Visible = false;
                btn_bargasht.Visible = true;
            }


            timer1.Enabled = true;
            timer1.Interval= 10;


            timer2.Enabled = true;
            timer2.Interval= 10;

            dataGridViewFinancial.AutoGenerateColumns = false;
            dataGridViewFinancial.ColumnCount = 11;
            dataGridViewFinancial.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewFinancial.Columns[0].Visible = true;
            dataGridViewFinancial.Columns[0].HeaderText = "کد";
            dataGridViewFinancial.Columns[0].DataPropertyName = "id";
            dataGridViewFinancial.Columns[0].Name = "id";

            dataGridViewFinancial.Columns[1].Visible = true;
            dataGridViewFinancial.Columns[1].HeaderText = "پزشک";
            dataGridViewFinancial.Columns[1].DataPropertyName = "fullname";



            dataGridViewFinancial.Columns[2].Visible = true;
            dataGridViewFinancial.Columns[2].HeaderText = "زمان ویزیت";
            dataGridViewFinancial.Columns[2].DataPropertyName = "time";

            dataGridViewFinancial.Columns[3].Visible = true;
            dataGridViewFinancial.Columns[3].HeaderText = "تاریخ تشکیل پرونده ";
            dataGridViewFinancial.Columns[3].DataPropertyName = "FilingDate";

            dataGridViewFinancial.Columns[4].Visible = true;
            dataGridViewFinancial.Columns[4].HeaderText = "نام بیمار";
            dataGridViewFinancial.Columns[4].DataPropertyName = "name";

            dataGridViewFinancial.Columns[5].Visible = true;
            dataGridViewFinancial.Columns[5].HeaderText = "نام خانوادگی بیمار";
            dataGridViewFinancial.Columns[5].DataPropertyName = "famliy";

            dataGridViewFinancial.Columns[6].Visible = true;
            dataGridViewFinancial.Columns[6].HeaderText = "قیمت سرویس ";
            dataGridViewFinancial.Columns[6].DataPropertyName = "price";

            dataGridViewFinancial.Columns[7].Visible = true;
            dataGridViewFinancial.Columns[7].HeaderText = " سرویس ";
            dataGridViewFinancial.Columns[7].DataPropertyName = "title";          

            dataGridViewFinancial.Columns[8].Visible = true;
            dataGridViewFinancial.Columns[8].HeaderText = "تاریخ ویزیت ";
            dataGridViewFinancial.Columns[8].DataPropertyName = "date";

            dataGridViewFinancial.Columns[9].Visible = true;
            dataGridViewFinancial.Columns[9].HeaderText = " نوع بیمه";
            dataGridViewFinancial.Columns[9].DataPropertyName = "insurance";

            dataGridViewFinancial.Columns[10].Visible = true;
            dataGridViewFinancial.Columns[10].HeaderText = " شماره دفترچه ";
            dataGridViewFinancial.Columns[10].DataPropertyName = "MedicalRecordNum";





            dataGridViewFinancial.DataSource=myDB.FinancialVW1.ToList();
        }
        int QeimatTamamShode = 0;
        int takhfif = 0;
        int bedehi = 0;

        int selectedGridIdFinancial = 0;
        private void dataGridViewFinancial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridIdFinancial = (int)dataGridViewFinancial.Rows[e.RowIndex].Cells["Id"].Value;
            
            var query2 = myDB.FinancialVW1.SingleOrDefault(s => s.Id == selectedGridIdFinancial);


            QeimatTamamShode = int.Parse( query2.Price.ToString());
            txt_Pardakht.Text = query2.Price.ToString();
            
        }

        private void DateID_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_takhfif_TextChanged(object sender, EventArgs e)
        {
            if (txt_takhfif.Text == "")
            {
                takhfif = 0;

            }
            else
            {
                takhfif = int.Parse (txt_takhfif.Text);

                // QeimatTamamShode += int.Parse(txt_bedehi.Text);


            }
        }

        private void txt_bedehi_TextChanged(object sender, EventArgs e)
        {
            if (txt_bedehi.Text == "")
            {
                bedehi = 0;

            }
            else
            {
                bedehi += int.Parse(txt_bedehi.Text);

               // QeimatTamamShode += int.Parse(txt_bedehi.Text);


            }
        }

        private void dataGridViewFinancial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_takhfif .Text= string.Empty;
            txt_bedehi.Text = string.Empty;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           // label1.Text = txt_test.Text.ToString();
           txt_LastPrice.Text=QeimatTamamShode.ToString();
        }

        private void txt_Pardakht_TextChanged(object sender, EventArgs e)
        {
          //  QeimatTamamShode=int.Parse( txt_Pardakht.Text.ToString());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var query2 = myDB.FinancialVW1.SingleOrDefault(s => s.Id == selectedGridIdFinancial);


            QeimatTamamShode = int.Parse(query2.Price.ToString());
            QeimatTamamShode -= takhfif;
            QeimatTamamShode += bedehi;
        }

        private void btn_chap_Click(object sender, EventArgs e)
        {
            frm_print FormPrint = new frm_print();
            datatransfer1.PrintInformation = selectedGridIdFinancial;
            datatransfer1.qeimatNahaii=int.Parse(txt_LastPrice.Text);
            if (txt_bedehi.Text=="")
            {
                datatransfer1.bedehi = 0;

            }
            else
            {
                datatransfer1.bedehi = int.Parse(txt_bedehi.Text.ToString());

            }
            if (txt_takhfif.Text=="")
            {
                datatransfer1.takhfif = 0;
            }
            else
            {
                datatransfer1.takhfif = int.Parse(txt_takhfif.Text.ToString());

            }


            FormPrint.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_bargasht_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            frm_login frmlogin = new frm_login();
            this.Hide();
            frmlogin.ShowDialog();
        }

        private void btn_bargasht_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
