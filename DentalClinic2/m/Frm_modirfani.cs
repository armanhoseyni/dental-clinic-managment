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
    public partial class Frm_modirfani : Form
    {
        public Frm_modirfani()
        {
            InitializeComponent();
        }
        int selectedGridId = 0;
        m.DB_dentist_clinicEntities myDB=new DB_dentist_clinicEntities();
        private void Frm_modirfani_Load(object sender, EventArgs e)
        {


            ////////////////////////////
            ///
            cmb_clock.Items.Add("8-10");
            cmb_clock.Items.Add("10-12");
            cmb_clock.Items.Add("12-14");
            cmb_clock.Items.Add("14-16");
            cmb_clock.Items.Add("16-18");
            cmb_clock.Items.Add("18-20");



            ////////////////
            ///
            cmb_date.Items.Add("شنبه");
            cmb_date.Items.Add("یکشنبه");
            cmb_date.Items.Add("دوشنبه");
            cmb_date.Items.Add("سه شنبه");
            cmb_date.Items.Add("چهارشنبه");
            cmb_date.Items.Add("پنج شنبه");
                
            /////////////
            dataGridViewDoctors.AutoGenerateColumns = false;
            dataGridViewDoctors.ColumnCount = 5;
            dataGridViewDoctors.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewDoctors.Columns[0].Visible = true;
            dataGridViewDoctors.Columns[0].HeaderText = "کد";
            dataGridViewDoctors.Columns[0].DataPropertyName = "Id";
            dataGridViewDoctors.Columns[0].Name = "Id";

            dataGridViewDoctors.Columns[1].Visible = true;
            dataGridViewDoctors.Columns[1].HeaderText = "نام";
            dataGridViewDoctors.Columns[1].DataPropertyName = "name";

            dataGridViewDoctors.Columns[2].Visible = true;
            dataGridViewDoctors.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridViewDoctors.Columns[2].DataPropertyName = "Lname";

            dataGridViewDoctors.Columns[3].Visible = true;
            dataGridViewDoctors.Columns[3].HeaderText = "کدملی";
            dataGridViewDoctors.Columns[3].DataPropertyName = "Ncode";


            dataGridViewDoctors.Columns[4].Visible = true;
            dataGridViewDoctors.Columns[4].HeaderText = "تخصص";
            dataGridViewDoctors.Columns[4].DataPropertyName = "docTypeId";
            dataGridViewDoctors.DataSource=myDB.TBL_doctors.ToList();
            ////////////////////
            ///
            dataGridViewTable.AutoGenerateColumns = false;
            dataGridViewTable.ColumnCount = 4;
            dataGridViewTable.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewTable.Columns[0].Visible = true;
            dataGridViewTable.Columns[0].HeaderText = "کد";
            dataGridViewTable.Columns[0].DataPropertyName = "id";
            dataGridViewTable.Columns[0].Name = "id";



            dataGridViewTable.Columns[1].Visible = true;
            dataGridViewTable.Columns[1].HeaderText = "نام و نام خانوادگی دکتر";
            dataGridViewTable.Columns[1].DataPropertyName = "fullname";

            dataGridViewTable.Columns[2].Visible = true;
            dataGridViewTable.Columns[2].HeaderText = "روز";
            dataGridViewTable.Columns[2].DataPropertyName = "date";

            dataGridViewTable.Columns[3].Visible = true;
            dataGridViewTable.Columns[3].HeaderText = "ساعت ";
            dataGridViewTable.Columns[3].DataPropertyName = "time";

            dataGridViewTable.DataSource = myDB.Vw_DentistsWorkTime.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_date.Text=="روز" || cmb_clock.Text=="ساعت")
            {
                MessageBox.Show(" روز و ساعت را مشخص کنید");
            }
            else {

                var q1 = myDB.TBL_ClinicDateTable.SingleOrDefault(s => s.date == cmb_date.Text & s.time == cmb_clock.Text);
                m.TBL_desntistsWorkTime NewTime = new m.TBL_desntistsWorkTime();
                var q = myDB.TBL_doctors.SingleOrDefault(s => s.Id == selectedGridId);

                NewTime.DentistsId = q.Id;
                NewTime.ClinicTimeId = q1.id;
                myDB.TBL_desntistsWorkTime.Add(NewTime);
                if (myDB.SaveChanges() != 0)
                {
                    txt_DocFullname.Text = string.Empty;
                    dataGridViewTable.DataSource = myDB.Vw_DentistsWorkTime.OrderByDescending(x => x.id).ToList();
                }
            }


        }
        
            
        private void dataGridViewDoctors_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId = (int)dataGridViewDoctors.Rows[e.RowIndex].Cells["Id"].Value;
            var q = myDB.TBL_doctors.SingleOrDefault(s => s.Id == selectedGridId);
            txt_DocFullname.Text = q.fullname.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ViewDoctors_Click(object sender, EventArgs e)
        {
            dataGridViewTable.Visible=false;
            dataGridViewDoctors.Visible=true;
        }

        private void btn_ViewTable_Click(object sender, EventArgs e)
        {
            dataGridViewTable.Visible = true;
            dataGridViewDoctors.Visible = false;
        }

        private void btn_bargasht_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
