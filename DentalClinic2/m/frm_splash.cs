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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
             counter++;
            if (counter==5)
            {
  
                    timer1.Stop();
                    this.Hide();
                    frm_login login = new frm_login();
                    login.Show();
            }
            
        }
        public void MyFunction()
        {
            frm_sn frm = new frm_sn();
            frm.Hide    ();
            timer1.Enabled = true;
            timer1.Start();
        }
        private void frm_splash_Load(object sender, EventArgs e)
        {
            string s = Microsoft.Win32.Registry
            .GetValue(@"HKEY_CURRENT_USER\Software\myapp", "sn","").ToString();


            if (s=="123456789")
            {
                
                MyFunction();
            }
            if (s!="123456789")
            {
                int x = Convert.ToInt32(Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\myapp", "count", "-999").ToString());
                if (x == -999)
                {
                    Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\myapp", "count", "4");
                    MyFunction();

                }
                else if (x > 0)
                {
                    Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\myapp", "count", (--x).ToString());
                    MyFunction();
                }
                else
                {
                    MessageBox.Show("فرصت استفاده از نسخه ازمایشی به اتمام رسیده لطفا برای استفاده از نسخه اصلی شماره سریال را وارد کنید ");
                        new frm_sn().ShowDialog();    
                }                  
                lbl_trialVersion.Text = x.ToString() + "time(s) to expire terial version!";
            }

            else 
            { 
                lbl_trialVersion.Text = "";
                  // frm_sn fr_sn= new frm_sn();
                    //fr_sn.Show();

            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_trialVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
