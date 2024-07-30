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
    public partial class frm_Media : Form
    {
        public frm_Media()
        {
            InitializeComponent();
        }
        m.DB_dentist_clinicEntities myDB = new m.DB_dentist_clinicEntities();

        private void btn_browser_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picbox1.ImageLocation=openFileDialog1.FileName;
            }
        }

        private void frm_Media_Load(object sender, EventArgs e)
        {

            
            lbl_PatID.Text=datatransfer1.CurrentPatId.ToString();
            /////////////
            ///
            dataGridViewImagesTBL.AutoGenerateColumns = false;
            dataGridViewImagesTBL.ColumnCount = 4;
            dataGridViewImagesTBL.DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewImagesTBL.Columns[0].Visible = true;
            dataGridViewImagesTBL.Columns[0].Width = 20;
            dataGridViewImagesTBL.Columns[0].HeaderText = "کد";
            dataGridViewImagesTBL.Columns[0].DataPropertyName = "Id";
            dataGridViewImagesTBL.Columns[0].Name = "Id";

            dataGridViewImagesTBL.Columns[1].Visible = true;
            dataGridViewImagesTBL.Columns[1].HeaderText = "موضوع";
            dataGridViewImagesTBL.Columns[1].Width = 300;
            dataGridViewImagesTBL.Columns[1].DataPropertyName = "title";

            dataGridViewImagesTBL.Columns[2].Visible = true;
            dataGridViewImagesTBL.Columns[2].HeaderText = "عکس ";
            dataGridViewImagesTBL.Columns[2].Width = 300;
            dataGridViewImagesTBL.Columns[2].DataPropertyName = "picture";

            dataGridViewImagesTBL.Columns[3].Visible = true;
            dataGridViewImagesTBL.Columns[3].HeaderText = "کد بیمار مرتبط";
            dataGridViewImagesTBL.Columns[3].Width = 300;
            dataGridViewImagesTBL.Columns[3].DataPropertyName = "PatientID";
            
         
            dataGridViewImagesTBL.DataSource=myDB.TBL_Images.OrderByDescending(s =>s.Id).ToList();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            m.TBL_Images newImage = new m.TBL_Images();
            newImage.title=txt_imgtitle.Text;
            newImage.patientID=int.Parse(lbl_PatID.Text);
            newImage.picture = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
            myDB.TBL_Images.Add(newImage);
            if (myDB.SaveChanges()!=0)
            {
                picbox1.ImageLocation = null;
                txt_imgtitle .Text= "";
                
            }
            
        }

        private void btn_ServerImg_Click(object sender, EventArgs e)
        {
            myDB.SaveChanges();
            label2.Visible = false;
            txt_imgtitle.Visible = false;
            lbl_PatID.Visible = false;
            label1.Visible = false;
            btn_apply.Visible = false;
            btn_browser.Visible = false;

            btn_ServerImg.Visible = false;
            btn_applyimg.Visible = true;
            btn_refresh.Visible = true;
            btn_deletImg.Visible = true;

            picbox1.Visible = false;
            picbox_serverImg.Visible = true;
            dataGridViewImagesTBL.Visible= true;  
            
        }
        int GridSelectedId = 0;
        private void dataGridViewImagesTBL_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridSelectedId = (int)dataGridViewImagesTBL.Rows[e.RowIndex].Cells["Id"].Value;
            var q = myDB.TBL_Images.Find(GridSelectedId).picture;
            picbox_serverImg.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream( q ) );
        }

        private void btn_applyimg_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            txt_imgtitle.Visible = true;
            lbl_PatID.Visible = true;
            label1.Visible = true;
            btn_apply.Visible = true;
            btn_browser.Visible = true;

            btn_ServerImg.Visible = true;
            btn_applyimg.Visible = false;
            btn_refresh.Visible = false;
            btn_deletImg.Visible = false;

            picbox1.Visible = true;
            picbox_serverImg.Visible = false;
            dataGridViewImagesTBL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletImg_Click(object sender, EventArgs e)
        {
            myDB.del_ImgById(GridSelectedId);
            dataGridViewImagesTBL.DataSource = myDB.TBL_Images.OrderByDescending(s => s.Id).ToList();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridViewImagesTBL.DataSource = myDB.TBL_Images.OrderByDescending(s => s.Id).ToList();

        }

        private void btn_bargasht_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
