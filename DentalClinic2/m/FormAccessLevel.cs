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
    public partial class FormAccessLevel : Form
    {
        public FormAccessLevel()
        {
            InitializeComponent();
        }
        m.DB_dentist_clinicEntities myDB = new m.DB_dentist_clinicEntities();

        private void FormAccessLevel_Load(object sender, EventArgs e)
        {

            cmb_AccessLevel.DisplayMember = "role";
            cmb_AccessLevel.ValueMember = "Id";
            cmb_AccessLevel.DataSource = myDB.TBL_RoleType.ToList();



            /////////////////////
            dataGridViewMoreinfoPer.AutoGenerateColumns = false;
            dataGridViewMoreinfoPer.Visible = true;
            dataGridViewMoreinfoPer.ColumnCount = 4;

            dataGridViewMoreinfoPer.Columns[0].Visible = true;
            dataGridViewMoreinfoPer.Columns[0].HeaderText = " کد ";
            dataGridViewMoreinfoPer.Columns[0].DataPropertyName = "Id";
            dataGridViewMoreinfoPer.Columns[0].Name = "Id";

            dataGridViewMoreinfoPer.Columns[1].Visible = true;
            dataGridViewMoreinfoPer.Columns[1].HeaderText = " کد پرسنل ";
            dataGridViewMoreinfoPer.Columns[1].DataPropertyName = "UserId";
           


            dataGridViewMoreinfoPer.Columns[2].Visible = true;
            dataGridViewMoreinfoPer.Columns[2].HeaderText = "نام کاربری";
            dataGridViewMoreinfoPer.Columns[2].DataPropertyName = "UserName";

            dataGridViewMoreinfoPer.Columns[3].Visible = true;
            dataGridViewMoreinfoPer.Columns[3].HeaderText = "سطح دسترسی";
            dataGridViewMoreinfoPer.Columns[3].DataPropertyName = "RoleTypeId";

            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Entrance.OrderByDescending(s => s.Id).ToList();
        }
        int selectedGridId = 0;
        private void dataGridViewMoreinfoPer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId = (int)dataGridViewMoreinfoPer.Rows[e.RowIndex].Cells["Id"].Value;
            var querysearchEntrance = myDB.TBL_Entrance.SingleOrDefault(s => s.Id == selectedGridId);

           txt_Pusername.Text= querysearchEntrance.UserName.ToString();
            txt_Pcode.Text=querysearchEntrance.Id.ToString();
            txt_accesslevelU.Text=querysearchEntrance.RoleTypeId.ToString();
            
        }

        private void btn_DefineAccessLevel_Click(object sender, EventArgs e)
        {
            var querysearchEntrance = myDB.TBL_Entrance.SingleOrDefault(s => s.Id == selectedGridId);


            querysearchEntrance.RoleTypeId=(int) cmb_AccessLevel.SelectedValue;
            myDB.SaveChanges();
            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Entrance.OrderByDescending(s => s.Id).ToList();

        }

        private void btn_bargasht_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
