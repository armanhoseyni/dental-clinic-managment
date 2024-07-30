using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic2.m
{
    public partial class frm_print : Form
    {
        public frm_print()
        {
            InitializeComponent();
        }

        










        /// <summary>
        /// /////////////////////
        /// </summary>
        m.DB_dentist_clinicEntities myDB=new m.DB_dentist_clinicEntities();
        private void frm_print_Load(object sender, EventArgs e)
        {

            btn_print.BackColor = Color.Gray;
            int PatId = datatransfer1.PrintInformation;
            var query=myDB.AppointmentVWs.SingleOrDefault(x=>x.Id == PatId);
            var query2= myDB.FinancialVW1.SingleOrDefault(x => x.Id == PatId);
            lbl_service.Text = query.title;
            lbl_pardakht.Text = query2.Price.ToString();
            lbl_bedehi.Text=(datatransfer1.bedehi.ToString());
            lbl_takhfif.Text = (datatransfer1.takhfif.ToString());

            lbl_qeimatnahaii.Text=datatransfer1.qeimatNahaii.ToString();
            lbl_name.Text = query.name;
            lbl_Lname.Text = query.famliy;
            lbl_Ncode.Text=query.Ncode.ToString();

            lbl_Mnumb.Text = query.MedicalRecordNum.ToString();






            lbl_tarikh.Text = DateTime.Now.ToString("yyyy/M/d");
            
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
            
        }
        Bitmap bitmap;

        private void button1_Click(object sender, EventArgs e)
        {
            btn_print.Visible = false;


            Panel panel=new Panel();
            this.Controls.Add(panel);

            Graphics graphics =panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap=new Bitmap(size.Width, size.Height,graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point=PointToScreen(panel.Location);

            graphics.CopyFromScreen (point.X,point.Y,0,0,size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();   



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
