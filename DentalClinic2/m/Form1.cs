using ChreneLib.Controls.TextBoxes;
using DentalClinic2.m;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        m.DB_dentist_clinicEntities myDB = new m.DB_dentist_clinicEntities();
        int selectedGridId1 = 0;
        int selectedGridId2 = 0;
        int selectedGridId3 = 0;
        int selectedGridIdSec = 0;
        int selectedGridIdSer = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////


            cmb_EdtService.DisplayMember = "title";
            cmb_EdtService.ValueMember = "Id";
            cmb_EdtService.DataSource = myDB.TBL_Services.ToList();
            ///
            ////////////
            ///

            ////////////////////////
            lbl_role.Text=datatransfer1.CurrentUserRole.ToString();
            //////////////////////
            ///

            cmb_EdtBime.Items.Add("تامین اجتماعی");
            cmb_EdtBime.Items.Add(" سلامت");
            cmb_EdtBime.Items.Add("نیروی مصلح ");


            cmb_bime.Items.Add("تامین اجتماعی");
            cmb_bime.Items.Add(" سلامت");
            cmb_bime.Items.Add("نیروی مصلح ");

            cmb_SrchBime.Items.Add("تامین اجتماعی");
            cmb_SrchBime.Items.Add(" سلامت");
            cmb_SrchBime.Items.Add("نیروی مصلح ");

            ///////////////////////access level/////

            switch (datatransfer1.CurrentUserRole)
            {
                ///oprator1
                case 19:gb_personel.Visible = false;
                    btn_modirfani.Visible = false;
                    btn_modirmali.Visible = false; 
                    
                
                    break;
                    /////oprator2
                    case 22: gb_personel.Visible = false;
                    btn_modirfani.Visible = false; 
                    btn_modirmali.Visible = false; 
                    break;
                    /////modir mali
                     case 16: modir_mali formmodirmali = new modir_mali();
                    this.Hide();
                    formmodirmali.ShowDialog() ;
                    break;

                    /////modir fani
                    case 13: tab_pat.Visible = false;
                    gb_appintment.Visible = false;   
                    break;

                default:
                    break;
            }

            ///////////////////////////////////
            ///

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[0].Name = "Id";

            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[1].DataPropertyName = "name";

            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridView1.Columns[2].DataPropertyName = "famliy";

            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[3].HeaderText = "کدملی";
            dataGridView1.Columns[3].DataPropertyName = "Ncode";
           // dataGridView1.DataSource=myDB.tbl

            ///////////////////////////////////////////
            dataGridViewMoreinfoPat.Visible = false;
            dataGridViewMoreinfoPat.AutoGenerateColumns = false;
            dataGridViewMoreinfoPat.ColumnCount = 8;

            dataGridViewMoreinfoPat.Columns[0].Visible = true;
            dataGridViewMoreinfoPat.Columns[0].HeaderText = "کد";
            dataGridViewMoreinfoPat.Columns[0].DataPropertyName = "Id";
            dataGridViewMoreinfoPat.Columns[0].Name = "Id";

            dataGridViewMoreinfoPat.Columns[1].Visible = true;
            dataGridViewMoreinfoPat.Columns[1].HeaderText = "نام";
            dataGridViewMoreinfoPat.Columns[1].DataPropertyName = "name";

            dataGridViewMoreinfoPat.Columns[2].Visible = true;
            dataGridViewMoreinfoPat.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridViewMoreinfoPat.Columns[2].DataPropertyName = "famliy";

            dataGridViewMoreinfoPat.Columns[3].Visible = true;
            dataGridViewMoreinfoPat.Columns[3].HeaderText = "کدملی";
            dataGridViewMoreinfoPat.Columns[3].DataPropertyName = "Ncode";

            dataGridViewMoreinfoPat.Columns[4].Visible = true;
            dataGridViewMoreinfoPat.Columns[4].HeaderText = "ادرس";
            dataGridViewMoreinfoPat.Columns[4].DataPropertyName = "address";


            dataGridViewMoreinfoPat.Columns[5].Visible = true;
            dataGridViewMoreinfoPat.Columns[5].HeaderText = "تلغن";
            dataGridViewMoreinfoPat.Columns[5].DataPropertyName = "tell";

            
            dataGridViewMoreinfoPat.Columns[6].Visible = true;
            dataGridViewMoreinfoPat.Columns[6].HeaderText = "جنسیت";
            dataGridViewMoreinfoPat.Columns[6].DataPropertyName = "gander";

            dataGridViewMoreinfoPat.Columns[7].Visible = true;
            dataGridViewMoreinfoPat.Columns[7].HeaderText = "تاریخ تولد";
            dataGridViewMoreinfoPat.Columns[7].DataPropertyName = "BirthDay";


            dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();


            dataGridView1.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            //////////////////////////////////
            /////DOC//////
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 5;
            dataGridView2.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridView2.Columns[0].Visible = true;
            dataGridView2.Columns[0].HeaderText = "کد";
            dataGridView2.Columns[0].DataPropertyName = "Id";
            dataGridView2.Columns[0].Name = "Id";

            dataGridView2.Columns[1].Visible = true;
            dataGridView2.Columns[1].HeaderText = "نام";
            dataGridView2.Columns[1].DataPropertyName = "name";

            dataGridView2.Columns[2].Visible = true;
            dataGridView2.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridView2.Columns[2].DataPropertyName = "Lname";

            dataGridView2.Columns[3].Visible = true;
            dataGridView2.Columns[3].HeaderText = "کدملی";
            dataGridView2.Columns[3].DataPropertyName = "Ncode";


            dataGridView2.Columns[4].Visible = true;
            dataGridView2.Columns[4].HeaderText = "تخصص";
            dataGridView2.Columns[4].DataPropertyName = "docTypeId";

            /////////////////////////////////////////////////////////////////
            dataGridViewMoreinfoDoc.AutoGenerateColumns = false;
            dataGridViewMoreinfoDoc.Visible=false;
            dataGridViewMoreinfoDoc.ColumnCount = 8;
            dataGridViewMoreinfoDoc.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewMoreinfoDoc.Columns[0].Visible = true;
            dataGridViewMoreinfoDoc.Columns[0].HeaderText = "کد";
            dataGridViewMoreinfoDoc.Columns[0].DataPropertyName = "Id";
            dataGridViewMoreinfoDoc.Columns[0].Name = "Id";

            dataGridViewMoreinfoDoc.Columns[1].Visible = true;
            dataGridViewMoreinfoDoc.Columns[1].HeaderText = "نام";
            dataGridViewMoreinfoDoc.Columns[1].DataPropertyName = "name";

            dataGridViewMoreinfoDoc.Columns[2].Visible = true;
            dataGridViewMoreinfoDoc.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridViewMoreinfoDoc.Columns[2].DataPropertyName = "Lname";

            dataGridViewMoreinfoDoc.Columns[3].Visible = true;
            dataGridViewMoreinfoDoc.Columns[3].HeaderText = "کدملی";
            dataGridViewMoreinfoDoc.Columns[3].DataPropertyName = "Ncode";


            dataGridViewMoreinfoDoc.Columns[4].Visible = true;
            dataGridViewMoreinfoDoc.Columns[4].HeaderText = "تخصص";
            dataGridViewMoreinfoDoc.Columns[4].DataPropertyName = "docTypeId";

            dataGridViewMoreinfoDoc.Columns[5].Visible = true;
            dataGridViewMoreinfoDoc.Columns[5].HeaderText = "جنسیت";
            dataGridViewMoreinfoDoc.Columns[5].DataPropertyName = "gender";

            dataGridViewMoreinfoDoc.Columns[6].Visible = true;
            dataGridViewMoreinfoDoc.Columns[6].HeaderText = "تاریخ تولد";
            dataGridViewMoreinfoDoc.Columns[6].DataPropertyName = "BirthDay";

            dataGridViewMoreinfoDoc.Columns[7].Visible = true;
            dataGridViewMoreinfoDoc.Columns[7].HeaderText = "تلفن";
            dataGridViewMoreinfoDoc.Columns[7].DataPropertyName = "tell";

            dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.OrderByDescending(s=>s.Id).ToList();

            ///////////////////
    
            /////////////////////
            ///personel
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnCount = 4;

            dataGridView4.Columns[0].Visible = true;
            dataGridView4.Columns[0].HeaderText = "کد";
            dataGridView4.Columns[0].DataPropertyName = "Id";
            dataGridView4.Columns[0].Name = "Id";

            dataGridView4.Columns[1].Visible = true;
            dataGridView4.Columns[1].HeaderText = "نام";
            dataGridView4.Columns[1].DataPropertyName = "name";

            dataGridView4.Columns[2].Visible = true;
            dataGridView4.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridView4.Columns[2].DataPropertyName = "family";

            dataGridView4.Columns[3].Visible = true;
            dataGridView4.Columns[3].HeaderText = "کد ملی";
            dataGridView4.Columns[3].DataPropertyName = "Ncode";

            
            /////////////
            dataGridViewMoreinfoPer.AutoGenerateColumns = false;
            dataGridViewMoreinfoPer.Visible = false;
            dataGridViewMoreinfoPer.ColumnCount = 10;

            dataGridViewMoreinfoPer.Columns[0].Visible = true;
            dataGridViewMoreinfoPer.Columns[0].HeaderText = "کد";
            dataGridViewMoreinfoPer.Columns[0].DataPropertyName = "Id";
            dataGridViewMoreinfoPer.Columns[0].Name = "Id";

            dataGridViewMoreinfoPer.Columns[1].Visible = true;
            dataGridViewMoreinfoPer.Columns[1].HeaderText = "نام";
            dataGridViewMoreinfoPer.Columns[1].DataPropertyName = "name";

            dataGridViewMoreinfoPer.Columns[2].Visible = true;
            dataGridViewMoreinfoPer.Columns[2].HeaderText = "نام خلنوادگی";
            dataGridViewMoreinfoPer.Columns[2].DataPropertyName = "family";

            dataGridViewMoreinfoPer.Columns[3].Visible = true;
            dataGridViewMoreinfoPer.Columns[3].HeaderText = "کد ملی";
            dataGridViewMoreinfoPer.Columns[3].DataPropertyName = "Ncode";

            dataGridViewMoreinfoPer.Columns[4].Visible = true;
            dataGridViewMoreinfoPer.Columns[4].HeaderText = " آدرس";
            dataGridViewMoreinfoPer.Columns[4].DataPropertyName = "Address";

            dataGridViewMoreinfoPer.Columns[5].Visible = true;
            dataGridViewMoreinfoPer.Columns[5].HeaderText = "تاریخ تولد";
            dataGridViewMoreinfoPer.Columns[5].DataPropertyName = "BirthDay";

            dataGridViewMoreinfoPer.Columns[6].Visible = true;
            dataGridViewMoreinfoPer.Columns[6].HeaderText = "تلغن";
            dataGridViewMoreinfoPer.Columns[6].DataPropertyName = "tell";

            dataGridViewMoreinfoPer.Columns[7].Visible = true;
            dataGridViewMoreinfoPer.Columns[7].HeaderText = "رزومه";
            dataGridViewMoreinfoPer.Columns[7].DataPropertyName = "resume";

            dataGridViewMoreinfoPer.Columns[8].Visible = true;
            dataGridViewMoreinfoPer.Columns[8].HeaderText = " جنسیت";
            dataGridViewMoreinfoPer.Columns[8].DataPropertyName = "gender";


            dataGridViewMoreinfoPer.Columns[9].Visible = true;
            dataGridViewMoreinfoPer.Columns[9].HeaderText = "نام کاربری";
            dataGridViewMoreinfoPer.Columns[9].DataPropertyName = "username";


            dataGridViewMoreinfoPer.DataSource=myDB.TBL_Users.OrderByDescending(s=>s.Id).ToList();

            dataGridView4.DataSource = myDB.TBL_Users.ToList();


            /////////////
            ///
            cmb_SrchService.DisplayMember = "title";
            cmb_SrchService.ValueMember = "Id";
            cmb_SrchService.DataSource = myDB.TBL_Services.ToList();
            ///////////////////////////

            cmb_DntTypeSrch.DisplayMember = "type";
            cmb_DntTypeSrch.ValueMember = "Id"; 
            cmb_DocSabt.DisplayMember = "type";
            cmb_DocSabt.ValueMember = "Id";
            //////////////////////////////////

            cmb_DocVirayesh.DisplayMember = "type";
            cmb_DocVirayesh.ValueMember = "Id";

            cmb_Services.DisplayMember = "title";
            cmb_Services.ValueMember = "Id";

            cmb_DocVirayesh.DataSource = myDB.TBL_DentistType.ToList();
            cmb_DocSabt.DataSource = myDB.TBL_DentistType.ToList();
            cmb_DntTypeSrch.DataSource = myDB.TBL_DentistType.ToList();

            cmb_Services.DataSource=myDB.TBL_Services.ToList();
            /////////


            ///////////////////////////
            ///
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnCount = 4;
            dataGridView3.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridView3.Columns[0].Visible = true;
            dataGridView3.Columns[0].HeaderText = "کد";
            dataGridView3.Columns[0].DataPropertyName = "id";
            dataGridView3.Columns[0].Name = "id";

            

            dataGridView3.Columns[1].Visible = true;
            dataGridView3.Columns[1].HeaderText = "نام و نام خانوادگی دکتر";
            dataGridView3.Columns[1].DataPropertyName = "fullname";

            dataGridView3.Columns[2].Visible = true;
            dataGridView3.Columns[2].HeaderText = "روز";
            dataGridView3.Columns[2].DataPropertyName = "date";

            dataGridView3.Columns[3].Visible = true;
            dataGridView3.Columns[3].HeaderText = "ساعت ";
            dataGridView3.Columns[3].DataPropertyName = "time";

            dataGridView3.DataSource = myDB.DoctorWorkTimeVWs.ToList();
            
            ///////////////////////////////////////////////////////////
            //mb_GndrPat.Items.Add("Male");
            //mb_GndrPat.Items.Add("Female");
            cmb_GndrSrchD.Items.Add("male");
            cmb_GndrSrchD.Items.Add("female");
            cmb_GndrSrchD.Items.Add("both");
            ////////////
            cmb_GndrAddPer.Items.Add("male");
            cmb_GndrAddPer.Items.Add("female");

            ///////////////
            cmb_GndrEdtPer.Items.Add("male");
            cmb_GndrEdtPer.Items.Add("female");
            cmb_GndrEdtPer.Items.Add("both");

            cmb_GndrSrchPer.Items.Add("male");
            cmb_GndrSrchPer.Items.Add("female");
            cmb_GndrSrchPer.Items.Add("both");

            cmb_GndrAddP.Items.Add("male");
            cmb_GndrAddP.Items.Add("female");
            //////////////////
            cmb_GndrAddD.Items.Add("male");
            cmb_GndrAddD.Items.Add("female");

            cmb_GndrSrchP.Items.Add("male");
            cmb_GndrSrchP.Items.Add("female");
            cmb_GndrSrchP.Items.Add("both");

            cmb_GndrEdtD.Items.Add("male");
            cmb_GndrEdtD.Items.Add("female");


            cmb_GndrEdtP.Items.Add("male");
            cmb_GndrEdtP.Items.Add("female");
            ////////////////
            ////////////////
            dataGridViewAppoitment.AutoGenerateColumns = false;
            dataGridViewAppoitment.ColumnCount = 12;
            dataGridViewAppoitment.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewAppoitment.Columns[0].Visible = true;
            dataGridViewAppoitment.Columns[0].HeaderText = "کد";
            dataGridViewAppoitment.Columns[0].DataPropertyName = "id";
            dataGridViewAppoitment.Columns[0].Name = "id";

            dataGridViewAppoitment.Columns[1].Visible = true;
            dataGridViewAppoitment.Columns[1].HeaderText = "پزشک";
            dataGridViewAppoitment.Columns[1].DataPropertyName = "fullname";
            

            
            dataGridViewAppoitment.Columns[2].Visible = true;
            dataGridViewAppoitment.Columns[2].HeaderText = "زمان ویزیت";
            dataGridViewAppoitment.Columns[2].DataPropertyName = "time";

            dataGridViewAppoitment.Columns[3].Visible = true;
            dataGridViewAppoitment.Columns[3].HeaderText = "تاریخ تشکیل پرونده ";
            dataGridViewAppoitment.Columns[3].DataPropertyName = "FilingDate";

            dataGridViewAppoitment.Columns[4].Visible = true;
            dataGridViewAppoitment.Columns[4].HeaderText = "نام بیمار";
            dataGridViewAppoitment.Columns[4].DataPropertyName = "name";

            dataGridViewAppoitment.Columns[5].Visible = true;
            dataGridViewAppoitment.Columns[5].HeaderText = "نام خانوادگی بیمار";
            dataGridViewAppoitment.Columns[5].DataPropertyName = "famliy";

            dataGridViewAppoitment.Columns[6].Visible = true;
            dataGridViewAppoitment.Columns[6].HeaderText = "تلفن بیمار";
            dataGridViewAppoitment.Columns[6].DataPropertyName = "tell";

            dataGridViewAppoitment.Columns[7].Visible = true;
            dataGridViewAppoitment.Columns[7].HeaderText = " سرویس ";
            dataGridViewAppoitment.Columns[7].DataPropertyName = "title";

            dataGridViewAppoitment.Columns[8].Visible = true;
            dataGridViewAppoitment.Columns[8].HeaderText = "نام کاربری پرسنل ";
            dataGridViewAppoitment.Columns[8].DataPropertyName = "UserName";

            dataGridViewAppoitment.Columns[9].Visible = true;
            dataGridViewAppoitment.Columns[9].HeaderText = "تاریخ ویزیت ";
            dataGridViewAppoitment.Columns[9].DataPropertyName = "date";

            dataGridViewAppoitment.Columns[10].Visible = true;
            dataGridViewAppoitment.Columns[10].HeaderText = " نوع بیمه";
            dataGridViewAppoitment.Columns[10].DataPropertyName = "insurance";

            dataGridViewAppoitment.Columns[11].Visible = true;
            dataGridViewAppoitment.Columns[11].HeaderText = " شماره دفترچه ";
            dataGridViewAppoitment.Columns[11].DataPropertyName = "MedicalRecordNum";






            dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            //private void prTextBox1_Load(object sender, EventArgs e)

        }

        private void txt_PatName_Load(object sender, EventArgs e)
        {

        }

        private void txt_PatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PatName_Enter(object sender, EventArgs e)
        {
        }

        private void btn_Sabt_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId1 = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
           
                var query2 = myDB.TBL_Patients.SingleOrDefault(s => s.Id == selectedGridId1);
            txt_EdtNamePat.Text = query2.name;
            txt_EdtFamilyPat.Text = query2.famliy;
            txt_EdtTellPat.Text = query2.tell;
            txt_EdtAdrsPat.Text = query2.address;
            txt_EdtNcodePat.Text = query2.Ncode;
            txt_EdtBdPat.Text = query2.BirthDay;
            cmb_GndrEdtP.Text = query2.gander;
            txt_PatID.Text = query2.Id.ToString();

        }

        private void Btn_Edt_Click(object sender, EventArgs e)
        {


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txt_SrchName_TextChanged(object sender, EventArgs e)
        {



        }

        private void cTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_N_Click(object sender, EventArgs e)
        {

        }

        private void txt_SrchFamly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SrchTell_TextChanged(object sender, EventArgs e)
        {


        }

        private void elGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_DntTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmb_DntTypeSrch.SelectedValue == 1)
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource=myDB.TBL_doctors.ToList();
            }
            else

            {
                var querySearch = myDB.TBL_doctors.Where(s => s.docTypeId == (int)cmb_DntTypeSrch.SelectedValue).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource= querySearch;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_SrchDocName_TextChanged(object sender, EventArgs e)
        {


        }

        private void cTextBox2txt_SrchDocFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void test1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_EdtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId2 = (int)dataGridView2.Rows[e.RowIndex].Cells["Id"].Value;
            var query3 = myDB.TBL_doctors.SingleOrDefault(s => s.Id == selectedGridId2);
            txt_DocNameEdt.Text = query3.name;
            txt_DocLnameEdt.Text = query3.Lname;
            txt_DocNcodEdt.Text = query3.Ncode.ToString();
           // txt_DocBdEdt.Text = query3.BirthDay.ToString();


            cmb_GndrEdtD.Text = query3.gender;

            cmb_DocVirayesh.SelectedValue = query3.docTypeId;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_VirayeshDoc_Click(object sender, EventArgs e)
        {
            var queryToSaveUpdates2 = myDB.TBL_doctors.SingleOrDefault(s => s.Id == selectedGridId2);

            queryToSaveUpdates2.name = txt_DocNameEdt.Text;
            queryToSaveUpdates2.Lname = txt_DocLnameEdt.Text;
            queryToSaveUpdates2.Ncode = txt_DocNcodEdt.Text;
            queryToSaveUpdates2.Address=txt_DocAdrsEdt.Text;
            queryToSaveUpdates2.tell=txt_DocTellEdt.Text;
            queryToSaveUpdates2.docTypeId = (int)cmb_DocVirayesh.SelectedValue;
            queryToSaveUpdates2.gender = cmb_GndrEdtD.Text;
            queryToSaveUpdates2.BirthDay=txt_DocBdEdt.Text;
            //queryToSaveUpdates2.BirthDay=dt_DocBdEdt.Value.ToShortDateString();
            myDB.SaveChanges();
            dataGridView2.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_SabtDoc_Click(object sender, EventArgs e)
        {

        }

        private void btn_DelP_Click(object sender, EventArgs e)
        {
            myDB.del_PatByID(selectedGridId1);
            dataGridView1.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_DelD_Click(object sender, EventArgs e)
        {
            myDB.del_DocByID(selectedGridId2);
            dataGridView2.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId3 = (int)dataGridView3.Rows[e.RowIndex].Cells["id"].Value;
            var query3 = myDB.TBL_desntistsWorkTime.SingleOrDefault(s => s.id == selectedGridId3);
           
            txt_DateID.Text = query3.id.ToString();

        }

        private void txt_SrchFamilyPat_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchFamilyPat.Text == "")
            {
              //  lbl_SrchFamilyPat.Visible= false;
                dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
            }
            else
            {
               // lbl_SrchFamilyPat.Visible = true;

                var querySearchName = myDB.TBL_Patients.Where(s => s.famliy.Contains(txt_SrchFamilyPat.Text)).ToList();
                dataGridView1.DataSource = querySearchName;
                querySearchName = myDB.TBL_Patients.Where(s => s.famliy.Contains(txt_SrchFamilyPat.Text)).ToList();
                dataGridViewMoreinfoPat.DataSource = querySearchName;
            }

        }

        private void txt_SrchNamePat_TextChanged(object sender, EventArgs e)
        {


            if (txt_SrchNamePat.Text == "")
            {
                dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
            }
            else
            {

                var querySearchName = myDB.TBL_Patients.Where(s => s.name.Contains(txt_SrchNamePat.Text)).ToList();
                dataGridView1.DataSource = querySearchName;
                querySearchName = myDB.TBL_Patients.Where(s => s.name.Contains(txt_SrchNamePat.Text)).ToList();
                dataGridViewMoreinfoPat.DataSource = querySearchName;
            }
            


        }

        private void txt_SrchTellPat_TextChanged(object sender, EventArgs e)
        {
           
                if (txt_SrchTellPat.Text == "")
                {
               // lbl_SrchTellPat.Visible=false;
                    dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                    dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
                }
                else
                {
              //  lbl_SrchTellPat.Visible = true;

                var querySearchName = myDB.TBL_Patients.Where(s => s.tell.Contains(txt_SrchTellPat.Text)).ToList();
                    dataGridView1.DataSource = querySearchName;
                    querySearchName = myDB.TBL_Patients.Where(s => s.tell.Contains(txt_SrchTellPat.Text)).ToList();
                    dataGridViewMoreinfoPat.DataSource = querySearchName;
                }
            
            
           
                

        }

        private void Btn_EdtPat_Click(object sender, EventArgs e)
        {
            var queryToSaveUpdates = myDB.TBL_Patients.SingleOrDefault(s => s.Id == selectedGridId1);
            queryToSaveUpdates.tell = txt_EdtTellPat.Text;
            queryToSaveUpdates.address = txt_EdtAdrsPat.Text;
            queryToSaveUpdates.name = txt_EdtNamePat.Text;
            queryToSaveUpdates.famliy = txt_EdtFamilyPat.Text;
            queryToSaveUpdates.Ncode = txt_EdtNcodePat.Text;
            queryToSaveUpdates.BirthDay = txt_EdtBdPat.Text;
            queryToSaveUpdates.gander = cmb_GndrEdtP.Text;
            myDB.SaveChanges();
            dataGridView1.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_AddNewPat_Click(object sender, EventArgs e)
        {
            m.TBL_Patients newPatient = new m.TBL_Patients();
            newPatient.name = txt_AddNamePat.Text;
            newPatient.famliy = txt_AddFamilyPat.Text;
            newPatient.tell = txt_AddTellPat.Text;
            newPatient.address = txt_AddAddrsPat.Text;
            newPatient.Ncode = txt_AddNcodePat.Text;
            //newPatient.BirthDay = txt_AddBdPat.Text;
            newPatient.BirthDay=dt_PatBdAdd.Value.ToShortDateString();
            newPatient.gander = cmb_GndrAddP.SelectedItem.ToString();
            myDB.TBL_Patients.Add(newPatient);
            int savechange = myDB.SaveChanges();

            if (savechange != 0)
            {
                MessageBox.Show("اطلاعات جدید با موفثیت ثبت شد");
            }
            
            foreach (var item in tb_patsave.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
        }

        private void btn_AddDoc_Click(object sender, EventArgs e)
        {





            ///////
            m.TBL_doctors newDOC = new m.TBL_doctors();
            newDOC.name = txt_DocNameAdd.Text;
            newDOC.Lname = txt_DocLnameAdd.Text;
            newDOC.docTypeId = (int)cmb_DntTypeSrch.SelectedValue;
            newDOC.gender = cmb_GndrAddD.SelectedItem.ToString();
            newDOC.Ncode = txt_DocNcodeAdd.Text;
            newDOC.Address = txt_DocAdrsAdd.Text;
            newDOC.BirthDay = dt_DocBdAdd.Value.ToShortDateString();
            
            newDOC.tell = txt_DocTellAdd.Text;
            
            myDB.TBL_doctors.Add(newDOC);
            int savechange = myDB.SaveChanges();

            if (savechange != 0)
            {
                MessageBox.Show("اطلاعات جدید با موفثیت ثبت شد");
            }
            else
            {
                MessageBox.Show("....مشکلی در ثبت پیش آمده");
            }

            foreach (var item in elTabPage3.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
            
        }

        private void txt_SrchDocLname_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocLname.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.Lname.Contains(txt_SrchDocLname.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource=querySearch;
            }
        }

        private void txt_SrchDocNamee_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocNamee.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.name.Contains(txt_SrchDocNamee.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource= querySearch;
            }
        }

        private void btn_AddtoAppoitnmnt_Click(object sender, EventArgs e)
        {
            //DocID.Text = txt_DocID.Text;

        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            PatID.Text = txt_PatID.Text;
        }

        private void GridViewSection_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridViewService_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void elButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddtoAppoitnmntDate_Click(object sender, EventArgs e)
        {
            DateID.Text = txt_DateID.Text;
        }

        private void elButton3_Click_1(object sender, EventArgs e)
        {
            frm_login frm2 = new frm_login();
            frm2.Show();
        }

        private void elButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_AddtoAppoitnmntSec_Click(object sender, EventArgs e)
        {
        }

        private void txt_EdtAdrsPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SrchDocNcode_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocNcode.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource=myDB.TBL_doctors.ToList() ;
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.Ncode.ToString().Contains(txt_SrchDocNcode.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource=querySearch; 
            }
        }

        private void txt_SrchDocBd_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocBd.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.BirthDay.Contains(txt_SrchDocBd.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource= querySearch;    
            }
        }

        private void cmb_GndrSrch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_GndrSrchD.Text == "both")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource=myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.gender == (cmb_GndrSrchD.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource=querySearch;
            }
        }

        private void txt_DocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cTextBox5_TextChanged(object sender, EventArgs e)
        {
           
                if (txt_SrchNcodePat.Text == "")
                {
                //lbl_SrchNcodePat.Visible = false;
                    dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                    dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
                }
                else
                {
              //  lbl_SrchNcodePat.Visible = false;

                var querySearchName = myDB.TBL_Patients.Where(s => s.Ncode.Contains(txt_SrchNcodePat.Text)).ToList();
                    dataGridView1.DataSource = querySearchName;
                    querySearchName = myDB.TBL_Patients.Where(s => s.Ncode.Contains(txt_SrchNcodePat.Text)).ToList();
                    dataGridViewMoreinfoPat.DataSource = querySearchName;
                }
            
           

        }

        private void txt_SrchBdPat_TextChanged(object sender, EventArgs e)
        {
            
                if (txt_SrchBdPat.Text == "")
                {
                //lbl_SrchBdPat.Visible = false;
                    dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                    dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
                }
                else
                {
              //  lbl_SrchBdPat.Visible = true;
                    var querySearchName = myDB.TBL_Patients.Where(s => s.BirthDay.Contains(txt_SrchBdPat.Text)).ToList();
                    dataGridView1.DataSource = querySearchName;
                    querySearchName = myDB.TBL_Patients.Where(s => s.BirthDay.Contains(txt_SrchBdPat.Text)).ToList();
                    dataGridViewMoreinfoPat.DataSource = querySearchName;
                }
            
            
        }

        private void txt_AddNcodePat_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmb_GndrSrchP_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (cmb_GndrSrchP.Text == "both")
                {
              //  lbl_GndrSrchP.Visible = false;
                    dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
                 }
                else
                {
               // lbl_GndrSrchP.Visible = true;

                var querySearch = myDB.TBL_Patients.Where(s => s.gander == (cmb_GndrSrchP.Text)).ToList();
                    dataGridView1.DataSource = querySearch;
                    querySearch = myDB.TBL_Patients.Where(s => s.gander == (cmb_GndrSrchP.Text)).ToList();
                    dataGridViewMoreinfoPat.DataSource = querySearch;
                  }
            
            
                
            
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void cTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SrchNamePer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchNamePer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.name.Contains(txt_SrchNamePer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource= querySearchName;
            }
        }

        private void txt_SrchFamilyPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchFamilyPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource= myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.family.Contains(txt_SrchFamilyPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource=querySearchName;
            }
        }

        private void txt_SrchTellPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchTellPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource=myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.tell.Contains(txt_SrchTellPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource= querySearchName;
            }
        }

        private void txt_SrchBdPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchBdPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource= myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.BirthDay.Contains(txt_SrchBdPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource=querySearchName;
            }
        }

        private void txt_SrchNcodPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchNcodPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource=myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.Ncode.Contains(txt_SrchNcodPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource= querySearchName;
            }
        }

        private void cmb_GndrSrchPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_GndrSrchPer.Text == "both")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource= myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_Users.Where(s => s.gender == (cmb_GndrSrchPer.Text)).ToList();
                dataGridView4.DataSource = querySearch;
                dataGridViewMoreinfoPer.DataSource=querySearch;
            }
        }
        int selectedGridId4 = 0;
        private void dataGridView4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId4 = (int)dataGridView4.Rows[e.RowIndex].Cells["Id"].Value;
            var query2 = myDB.TBL_Users.SingleOrDefault(s => s.Id == selectedGridId4);
            txt_EdtNamePer.Text = query2.name;
            txt_EdtFamilyPer.Text = query2.family;
            txt_EdtTellPer.Text = query2.tell;
            txt_EdtAdrsPer.Text = query2.Address;
            txt_EdtNcodePer.Text = query2.Ncode;
            txt_EdtResPer.Text = query2.resume;
            txt_EdtBdPer.Text = query2.BirthDay;
            cmb_GndrEdtPer.Text = query2.gender;


            //txt_PatID.Text = query2.Id.ToString();
        }

        private void Btn_EdtPer_Click(object sender, EventArgs e)
        {
            var queryToSaveUpdates = myDB.TBL_Users.SingleOrDefault(s => s.Id == selectedGridId4);
            queryToSaveUpdates.tell = txt_EdtTellPer.Text;
            queryToSaveUpdates.Address = txt_EdtAdrsPer.Text;
            queryToSaveUpdates.name = txt_EdtNamePer.Text;
            queryToSaveUpdates.family = txt_EdtFamilyPer.Text;
            queryToSaveUpdates.username=txt_EdtUnamePer.Text;
            queryToSaveUpdates.Ncode = txt_EdtNcodePer.Text;
            queryToSaveUpdates.resume = txt_EdtResPer.Text;
            queryToSaveUpdates.BirthDay = txt_EdtBdPat.Text;
            //queryToSaveUpdates.gander = cmb_GndrEdtP.Text;
            myDB.SaveChanges();
            dataGridView4.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_DelPer_Click(object sender, EventArgs e)
        {
            myDB.del_PersonelByID(selectedGridId4);
            dataGridView4.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
        }

        private void txt_AddNamePat_TextChanged(object sender, EventArgs e)
        {
            if (txt_AddNamePat.Text=="")
            {
                //lbl_AddNamePat.Visible= false;
            }
            else
            {
                //lbl_AddNamePat.Visible = true;
            }
        }

        private void btn_AddNewPer_Click(object sender, EventArgs e)
        {
            m.TBL_Users newPersonel = new m.TBL_Users();
            newPersonel.name = txt_AddNamePer.Text;
            newPersonel.family = txt_AddFamilyPer.Text;
            newPersonel.tell = txt_AddTellPer.Text;
            newPersonel.username = txt_AddUnamePer.Text;
            newPersonel.Address = txt_AddAddrsPer.Text;
            newPersonel.Ncode = txt_AddNcodePer.Text;
            newPersonel.resume=txt_AddResPer.Text;
            newPersonel.BirthDay=dt_PerBdAdd.Value.ToShortDateString();
           // newPersonel.BirthDay = txt_AddBdPer.Text;
            newPersonel.gender = cmb_GndrAddPer.SelectedItem.ToString();
            myDB.TBL_Users.Add(newPersonel);
            int savechange = myDB.SaveChanges();

            if (savechange != 0)
            {
                MessageBox.Show("اطلاعات جدید با موفثیت ثبت شد");
            }
            
            foreach (var item in tb_PerAdd.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
            dataGridView4.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
        }

        private void cmb_GndrEdtP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_GndrAddP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tb_EdtPat_Click(object sender, EventArgs e)
        {

        }

        private void elTab1_Click(object sender, EventArgs e)
        {

        }

        private void btn_RefEdtPat_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_RefSrchPat_Click(object sender, EventArgs e)
        {
            foreach (var item in tb_SrchPat.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
            cmb_GndrSrchP.Text = "both";
        }

        private void elLabel23_Click(object sender, EventArgs e)
        {

        }

        private void btn_RefAddPat_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.OrderByDescending(s => s.Id).ToList();
            foreach (var item in tb_patsave.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
            dt_PatBdAdd.Text = string.Empty;

        }

        private void btn_RefSrchDoc_Click(object sender, EventArgs e)
        {
            foreach (var item in eltab_srchdoc.Controls)
            {
                if (item is CTextBox ) 
                {
                    ((CTextBox)item).Text = string.Empty;
                    
                }
                cmb_DntTypeSrch.SelectedValue =1;
                cmb_GndrSrchD.Text = "both";
            }
        }

        private void btn_RefEdtDoc_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_RefAddDoc_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource=myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.OrderByDescending(s => s.Id).ToList();
            foreach (var item in eltab_Sabtdoc.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
        }

        private void cTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_test_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dt_SrchDoc_ValueChanged(object sender, EventArgs e)
        {
           
                
            
        }

        private void txt_SrchAdrsPat_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                if (txt_SrchAdrsPat.Text == "")
                {
                    //lbl_SrchAdrsPat.Visible = false;
                    dataGridView1.DataSource = myDB.TBL_Patients.ToList();
                    dataGridViewMoreinfoPat.DataSource = myDB.TBL_Patients.ToList();
                }
                else
                {
                    //lbl_SrchAdrsPat.Visible = true;

                    var querySearchName = myDB.TBL_Patients.Where(s => s.address.Contains(txt_SrchAdrsPat.Text)).ToList();
                    dataGridView1.DataSource = querySearchName;
                    querySearchName = myDB.TBL_Patients.Where(s => s.address.Contains(txt_SrchAdrsPat.Text)).ToList();
                    dataGridViewMoreinfoPat.DataSource = querySearchName;
                }
            }
            
            
            
                 
                
                     
            
        }
        private void txt_SrchResPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchResPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource=myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.resume.Contains(txt_SrchResPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource=querySearchName;
            }
        }

        private void txt_AddNamePer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RefAddPer_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
            foreach (var item in tb_PerAdd.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
        }

        private void btn_RefEdtPer_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
            dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.OrderByDescending(s => s.Id).ToList();
        }

        private void btn_RefSrchPer_Click(object sender, EventArgs e)
        {
            foreach (var item in tb_SrchPer.Controls)
            {
                if (item is CTextBox)
                {
                    ((CTextBox)item).Text = string.Empty;
                }
            }
            cmb_GndrSrchPer.Text = "both";
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_MoreInfoPat_Click(object sender, EventArgs e)
        {
            btn_MoreInfoPat.Visible = false;
            btn_LessInfoPat.Visible = true;
            dataGridView1.Visible = false;
            dataGridViewMoreinfoPat.Visible = true;
        }

        private void btn_LessInfoPat_Click(object sender, EventArgs e)
        {
            btn_MoreInfoPat.Visible = true;
            btn_LessInfoPat.Visible = false;
            dataGridView1.Visible = true;
            dataGridViewMoreinfoPat.Visible = false;
        }

        private void dataGridViewMoreinfoPat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId1 = (int)dataGridViewMoreinfoPat.Rows[e.RowIndex].Cells["Id"].Value;

            var query2 = myDB.TBL_Patients.SingleOrDefault(s => s.Id == selectedGridId1);
            txt_EdtNamePat.Text = query2.name;
            txt_EdtFamilyPat.Text = query2.famliy;
            txt_EdtTellPat.Text = query2.tell;
            txt_EdtAdrsPat.Text = query2.address;
            txt_EdtNcodePat.Text = query2.Ncode;
            txt_EdtBdPat.Text = query2.BirthDay;
            cmb_GndrEdtP.Text = query2.gander;
            txt_PatID.Text = query2.Id.ToString();
        }

        private void btn_MoreInfoDoc_Click(object sender, EventArgs e)
        {
            btn_MoreInfoDoc.Visible = false;
            btn_LessInfoDoc.Visible = true;
            dataGridView2.Visible = false;
            dataGridViewMoreinfoDoc.Visible = true;
        }

        private void btn_LessInfoDoc_Click(object sender, EventArgs e)
        {
            btn_MoreInfoDoc.Visible = true;
            btn_LessInfoDoc.Visible = false;
            dataGridView2.Visible = true;
            dataGridViewMoreinfoDoc.Visible = false;
        }

        private void btn_MoreInfoPer_Click(object sender, EventArgs e)
        {
            btn_MoreInfoPer.Visible = false;
            btn_LessInfoPer.Visible = true;
            dataGridView2.Visible = false;
            dataGridViewMoreinfoPer.Visible = true;
        }

        private void btn_LessInfoPer_Click(object sender, EventArgs e)
        {
            btn_MoreInfoPer.Visible = true;
            btn_LessInfoPer.Visible = false;
            dataGridView2.Visible = true;
            dataGridViewMoreinfoPer.Visible = false;
        }

        private void dataGridViewMoreinfoDoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId2 = (int)dataGridViewMoreinfoDoc.Rows[e.RowIndex].Cells["Id"].Value;
            var query3 = myDB.TBL_doctors.SingleOrDefault(s => s.Id == selectedGridId2);
            txt_DocNameEdt.Text = query3.name;
            txt_DocLnameEdt.Text = query3.Lname;
            txt_DocNcodEdt.Text = query3.Ncode.ToString();
            txt_DocBdEdt.Text = query3.BirthDay.ToString();
            txt_DocAdrsEdt.Text=query3.Address.ToString();
            //dt_DocBdEdt.Value.Date()=query3.BirthDay.ToString();
            cmb_GndrEdtD.Text = query3.gender;

            cmb_DocVirayesh.SelectedValue = query3.docTypeId;
        }
        int selectedGridId5 = 0;
        private void dataGridViewMoreinfoPer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedGridId4 = (int)dataGridViewMoreinfoPer.Rows[e.RowIndex].Cells["Id"].Value;
            var query2 = myDB.TBL_Users.SingleOrDefault(s => s.Id == selectedGridId4);
            var query3 = myDB.TBL_Entrance.SingleOrDefault(s=>s.UserId == selectedGridId5);
            txt_EdtNamePer.Text = query2.name;
            txt_EdtFamilyPer.Text = query2.family;
            txt_EdtTellPer.Text = query2.tell;
            txt_EdtAdrsPer.Text = query2.Address;
            txt_EdtNcodePer.Text = query2.Ncode;
            txt_EdtResPer.Text = query2.resume;
            txt_EdtUnamePer.Text=query2.username;
            txt_EdtBdPer.Text = query2.BirthDay;
            cmb_GndrEdtPer.Text = query2.gender;
            //txt_PerID.Text = query3.Id.ToString();

        }

        private void tb_SrchPat_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddtoAppoitnmntPer_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_AddAddrsPer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SrchAdrsPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchAdrsPer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.Address.Contains(txt_SrchAdrsPer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource = querySearchName;
            }
        }

        private void txt_SrchDocTell_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocTell.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.tell.Contains(txt_SrchDocTell.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource = querySearch;
            }
        }

        private void txt_SrchDocAdrs_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDocAdrs.Text == "")
            {
                dataGridView2.DataSource = myDB.TBL_doctors.ToList();
                dataGridViewMoreinfoDoc.DataSource = myDB.TBL_doctors.ToList();
            }
            else
            {
                var querySearch = myDB.TBL_doctors.Where(s => s.Address.ToString().Contains(txt_SrchDocAdrs.Text)).ToList();
                dataGridView2.DataSource = querySearch;
                dataGridViewMoreinfoDoc.DataSource = querySearch;
            }
        }

        private void txt_DocNcodeAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_DocBdAdd_ValueChanged(object sender, EventArgs e)
        {
            //tesst.Text=dt_DocBdAdd.Value.Date.ToString();
        }

        private void txt_SrchUnamePer_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchUnamePer.Text == "")
            {
                dataGridView4.DataSource = myDB.TBL_Users.ToList();
                dataGridViewMoreinfoPer.DataSource = myDB.TBL_Users.ToList();
            }
            else
            {
                var querySearchName = myDB.TBL_Users.Where(s => s.username.Contains(txt_SrchUnamePer.Text)).ToList();
                dataGridView4.DataSource = querySearchName;
                dataGridViewMoreinfoPer.DataSource = querySearchName;
            }
        }

        private void dt_tst_ValueChanged(object sender, EventArgs e)
        {
            //tesst.Text=dt_tst.Value.ToShortDateString();
        }

        private void dataGridViewMoreinfoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_SrchDate_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDate1.Text == "")
            {
                dataGridView3.DataSource = myDB.Vw_DentistsWorkTime.ToList();

            }
            else
            {
                var querySearch = myDB.Vw_DentistsWorkTime.Where(s => s.date.Contains(txt_SrchDate1.Text)).ToList();
                dataGridView3.DataSource = querySearch;

            }
        }

        private void txt_SrchTime_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchTime1.Text == "")
            {
                dataGridView3.DataSource = myDB.Vw_DentistsWorkTime.ToList();
               
            }
            else
            {
                var querySearch = myDB.Vw_DentistsWorkTime.Where(s => s.time.Contains(txt_SrchTime1.Text)).ToList();
                dataGridView3.DataSource = querySearch;
                
            }
        }

        private void txt_SrchSection_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_SrchDocName_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_SrchDocName.Text == "")
            {
                dataGridView3.DataSource = myDB.Vw_DentistsWorkTime.ToList();

            }
            else
            {
                var querySearch = myDB.Vw_DentistsWorkTime.Where(s => s.fullname.Contains(txt_SrchDocName.Text)).ToList();
                dataGridView3.DataSource = querySearch;

            }
        }

        private void txt_SrchDocFamily_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_SrchService_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_SabtAppointment_Click(object sender, EventArgs e)
        {
            m.TBL_Appointment NewAppointment= new m.TBL_Appointment();
            NewAppointment.PatientId = int.Parse(PatID.Text);
            NewAppointment.FilingDate =DateTime.Now.ToString();
            NewAppointment.insurance = cmb_bime.SelectedItem.ToString();
            NewAppointment.ServiceId = cmb_selectedServId;
            NewAppointment.DocVisitId = int.Parse(DateID.Text);
            NewAppointment.UserId=int.Parse( lbl_role.Text);
            NewAppointment.MedicalRecordNum =int.Parse( txt_AddNoteNum.Text);
            myDB.TBL_Appointment.Add(NewAppointment);
            if (myDB.SaveChanges()!=0 )

            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
                MessageBox.Show("ok");

            }
        }
        int cmb_selectedServId = 0;
        private void cmb_Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_selectedServId= (int)cmb_Services.SelectedValue;
        }

        private void SectionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAppoitment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMoreinfoDoc_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btn_gotoaccesslevelform_Click(object sender, EventArgs e)
        {
            FormAccessLevel form_accesslevel = new FormAccessLevel();
            this.Hide();

            form_accesslevel.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            frm_login form_login = new frm_login();
            this.Hide();
            form_login.ShowDialog();
        }

        private void btn_applyImg_Click(object sender, EventArgs e)
        {
            frm_Media form_media=new frm_Media();
            this.Hide();

            datatransfer1.CurrentPatId = int.Parse(txt_PatID.Text);
            form_media.ShowDialog();
        }
        int selectedgrididAP = 0;
        private void btn_delAp_Click(object sender, EventArgs e)
        {
            myDB.del_apById(selectedgrididAP);
            dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
        }

        private void dataGridViewAppoitment_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedgrididAP = (int)dataGridViewAppoitment.Rows[e.RowIndex].Cells["Id"].Value;
            //var query3 = myDB.AppointmentVWs.SingleOrDefault(s => s.Id == selectedgrididAP);

            var query4 = myDB.AppointmentVWs.SingleOrDefault(s => s.Id == selectedgrididAP);

           // txt_EdtDoc.Text = query3.fullname.ToString();
            //txt_EdtNoteNum.Text = query3.MedicalRecordNum.ToString();
            //txt_EdtPat.Text = query3.famliy;
           // cmb_EdtBime.Text = query3.insurance;
          //  cmb_EdtService.Text = query3.title;
            txt_EdtDoc.Text = query4.fullname.ToString();
            txt_EdtNoteNum.Text = query4.MedicalRecordNum.ToString();
            txt_EdtPat.Text = query4.famliy.ToString();
            cmb_EdtBime.Text = query4.insurance;
            cmb_EdtService.Text = query4.title.ToString();


        }

        private void btn_modirfani_Click(object sender, EventArgs e)
        {
            m.Frm_modirfani formmodirfani=new m.Frm_modirfani();
            formmodirfani.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void elTabPage8_Click(object sender, EventArgs e)
        {

        }

        private void elTabPage9_Click(object sender, EventArgs e)
        {
        }

        private void btn_EdtAP_Click(object sender, EventArgs e)
        {
           // var queryToSaveUpdates3 = myDB.AppointmentVWs.SingleOrDefault(s => s.fullname== txt_EdtDoc.Text);
            //var queryToSaveUpdates4= myDB.AppointmentVWs.SingleOrDefault(s => s.famliy== txt_EdtPat.Text);

            //var queryToSaveUpdates2 = myDB.TBL_Appointment.SingleOrDefault(s => s.Id == selectedgrididAP);
           // queryToSaveUpdates2.insurance = cmb_EdtBime.SelectedItem.ToString();
            //queryToSaveUpdates2.DocVisitId =int.Parse( txt_EdtDoc.Text);
           // queryToSaveUpdates2.ServiceId =  selectedServIdE;
            //queryToSaveUpdates2.PatientId = int.Parse(txt_EdtPat.Text);
       //     queryToSaveUpdates2.insurance = cmb_EdtBime.SelectedValue.ToString();
            //queryToSaveUpdates2.MedicalRecordNum = int.Parse(txt_EdtNoteNum.Text);
            //myDB.SaveChanges();
            //dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        int selectedServIdE = 0;
        private void cmb_EdtService_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedServIdE = (int)cmb_EdtService.SelectedValue;

        }
        int selectedEdtDoc = 0;
        private void dataGridViewEditDoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void txt_EdtDocIdChek_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EdtDocCheck_Click(object sender, EventArgs e)
        {
        }

        private void txt_EdtDoc_Enter(object sender, EventArgs e)
        {

        }
        int selectedEdtPat = 0;
        private void dataGridView5_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_EdtPatCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_EdtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EdtPat_Enter(object sender, EventArgs e)
        {
        }

        private void txt_EdtPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RefAp_Click(object sender, EventArgs e)
        {

        }

        private void btn_RefAp_Click_1(object sender, EventArgs e)
        {
            dataGridViewAppoitment.DataSource=myDB.AppointmentVWs.OrderByDescending (s=>s.Id).ToList();
        }

        private void txt_SrchDoc_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchDoc.Text == "")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.fullname.Contains(txt_SrchDoc.Text)).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void txt_SrchDate_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_SrchDate.Text == "")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.date.Contains(txt_SrchDate.Text)).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void txt_SrchTime_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_SrchTime.Text == "")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.time.Contains(txt_SrchTime.Text)).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void txt_SrchPatFamily_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchPatFamily.Text == "")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.famliy.Contains(txt_SrchPatFamily.Text)).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void txt_SrchMedicalNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_SrchMedicalNum.Text == "")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.MedicalRecordNum.ToString().Contains(txt_SrchMedicalNum.Text)).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void cmb_SrchBime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SrchBime.Text == "هیچکدام")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
                var querySearch = myDB.AppointmentVWs.Where(s => s.insurance.ToString().Contains(cmb_SrchBime.SelectedItem.ToString())).ToList();
                dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void elGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_SrchService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SrchService.Text == "هیچکدام")
            {
                dataGridViewAppoitment.DataSource = myDB.AppointmentVWs.ToList();
            }
            else
            {
             //   var querySearch = myDB.AppointmentVWs.Where(s => s.title.ToString().Contains(cmb_SrchService.SelectedItem.ToString())).ToList();
              // dataGridViewAppoitment.DataSource = querySearch;
            }
        }

        private void btn_test1_Click(object sender, EventArgs e)
        {
        }

        private void cmb_GndrEdtD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_SrchDocNamee_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_SrchDocNcode_Enter(object sender, EventArgs e)
        {
           
        }

        private void txt_SrchDocAdrs_Enter(object sender, EventArgs e)
        {
          
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_amaliatPat_Click(object sender, EventArgs e)
        {
            tab_patients.Visible = true;
            btn_amaliatPat.Visible =false;
            btn_EtmamAmaliatPat.Visible =true;
        }

        private void elButton1_Click_2(object sender, EventArgs e)
        {
            tab_patients.Visible = false;
            btn_EtmamAmaliatPat.Visible = false;
            btn_amaliatPat.Visible =true;
        }

        private void btn_EtmamAmaliatPer_Click(object sender, EventArgs e)
        {
            btn_EtmamAmaliatPer.Visible = false;
            btn_amaliatPer.Visible =true;   
            tab_personels.Visible = false;
        }

        private void btn_amaliatPer_Click(object sender, EventArgs e)
        {

            btn_amaliatPer.Visible = false;
            btn_EtmamAmaliatPer.Visible = true;
            tab_personels.Visible = true;
        }

        private void btn_EtmamAmaliatPer1_Click(object sender, EventArgs e)
        {
            btn_EtmamAmaliatPer1.Visible = false;
            btn_amaliatPer1.Visible = true;
            eltab_Sabtdoc.Visible = false;
        }

        private void btn_amaliatPer1_Click(object sender, EventArgs e)
        {
            btn_EtmamAmaliatPer1.Visible = true;
            btn_amaliatPer1.Visible = false;
            eltab_Sabtdoc.Visible = true;
        }

        private void txt_SrchNamePat_Enter(object sender, EventArgs e)
        {
           

        }

        private void txt_SrchNamePat_Leave(object sender, EventArgs e)
        {

        }

        private void tb_patsave_Click(object sender, EventArgs e)
        {

        }

        private void txt_EdtNamePat_TextChanged(object sender, EventArgs e)
        {
            if (txt_EdtNamePat.Text=="")
            {
                lbl_EdtNamePat.Visible = false;
            }
            else
            {
                lbl_EdtNamePat.Visible = true;

            }
        }

        private void PatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_AddFamilyPat_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txt_AddTellPat_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txt_AddAddrsPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_PatBdAdd_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modirmali_Click(object sender, EventArgs e)
        {
            modir_mali modirmali=new modir_mali();  
            this.Hide();
            modirmali.ShowDialog();
        }

        private void lbl_role_Click(object sender, EventArgs e)
        {

        }

        private void bnt_exitt_Click(object sender, EventArgs e)
        {
           
        }

        private void gb_personel_Click(object sender, EventArgs e)
        {

        }

        private void elLabel40_Click(object sender, EventArgs e)
        {

        }
    }
}
