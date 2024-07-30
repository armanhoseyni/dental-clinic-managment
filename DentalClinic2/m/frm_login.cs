using ChreneLib.Controls.TextBoxes;
using DentalClinic2.m;
using Klik.Windows.Forms.v1.EntryLib;
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DentalClinic2
{
    public partial class frm_login : Form
    {
        m.DB_dentist_clinicEntities myDB = new m.DB_dentist_clinicEntities();
        public frm_login()
        {
            InitializeComponent();
        }

        private void tst_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            gb_login.Visible = false;
            gb_signup.Visible = true;
        }
        bool IsNew = false;
        private void txt_NcodeSignUp_TextChanged(object sender, EventArgs e)
        {
            if (txt_NcodeSignUp.Text == "")
            {
                lbl_eror.Visible = false;
                btn_UserReg.Visible = true;

            }
            var q = myDB.TBL_Users.Where(s => s.Ncode == txt_NcodeSignUp.Text).ToList();
            if (q.Count == 0)
            {
                lbl_eror.Visible = false;
                btn_UserReg.Visible = true;
            }
        }
        int NewUserID = 0;
        int NewEntranceId = 0;
        private void btn_UserReg_Click(object sender, EventArgs e)
        {
           // m.TBL_Users NewUsr = new m.TBL_Users();
           
            if (IsNew)
            {
                //NewUsr.Ncode = txt_NcodeSignUp.Text;
               // NewUsr.Address = txt_AdrsSignUp.Text;
               // NewUsr.name = txt_NameSignUp.Text;
              //  NewUsr.family = txt_FamilySignUp.Text;
               // NewUsr.tell = txt_TellSignUp.Text;
               // NewUsr.gender = cmb_GndrSignup.SelectedItem.ToString();
              //  NewUsr.BirthDay = dt_Signup.Value.ToShortDateString();
                ///NewUsr.username = "aa";
             //   myDB.TBL_Users.Add(NewUsr);
               // NewUserID = myDB.TBL_Users.Max(s => s.Id);
               
                
                    MessageBox.Show("Succeessfully registered!");
                    gb_UP.Visible = true;
                   


                

            }
        }
        private void txt_NcodeSignUp_Leave(object sender, EventArgs e)
        {

        }

        private void gb_signup_Enter(object sender, EventArgs e)
        {

        }

        private void dt_Signup_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_NcodeSignUp_Leave_1(object sender, EventArgs e)
        {
            var q = myDB.TBL_Users.Where(s => s.Ncode == txt_NcodeSignUp.Text).ToList();
            if (q.Count == 0)
            {
                IsNew = true;
                lbl_eror.Visible = false;

            }
            else
            {
                IsNew = false;
                lbl_eror.Visible = true;
                btn_UserReg.Visible = false;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
            cmb_RoleType.DisplayMember = "role";
            cmb_RoleType.ValueMember = "Id";
            cmb_RoleType.DataSource = myDB.TBL_RoleType.ToList();   
            timer1.Interval = 100;
            cmb_GndrSignup.Items.Add("male");
            cmb_GndrSignup.Items.Add("female");
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                lbl_Ueror.Visible = false;
                
            }
            var q = myDB.TBL_Users.Where(s => s.username == txt_username.Text).ToList();
            if (q.Count() != 0)
            {
                txt_repass.Visible = false;
                txt_pass.Visible = false;
                lbl_Ueror.Visible = true;
                btn_newP.Visible = false;
            }
            else
            {
                txt_repass.Visible = true;
                txt_pass.Visible = true;
                lbl_Ueror.Visible = false;
                btn_newP.Visible = true;
            }
        }

        private void btn_newP_Click(object sender, EventArgs e)
        {

            if (txt_pass.Text == txt_repass.Text)
            {
                
                m.TBL_Users NewUsr = new m.TBL_Users();
                m.TBL_Entrance NewEntrance = new m.TBL_Entrance();


                byte[] b = System.Text.Encoding.UTF8.GetBytes(txt_pass.Text);
                System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();
                byte[] hashedpass = h.ComputeHash(b);


                    NewUsr.Ncode = txt_NcodeSignUp.Text;
                    NewUsr.resume = txt_resume.Text;
                    NewUsr.Address = txt_AdrsSignUp.Text;
                    NewUsr.name = txt_NameSignUp.Text;
                    NewUsr.family = txt_FamilySignUp.Text;
                    NewUsr.tell = txt_TellSignUp.Text;
                    NewUsr.gender = cmb_GndrSignup.SelectedItem.ToString();
                    NewUsr.BirthDay = dt_Signup.Value.ToShortDateString();

                    
                    myDB.TBL_Users.Add(NewUsr);
                    myDB.SaveChanges();
                    NewUserID = myDB.TBL_Users.Max(s => s.Id);
                    

                var q = myDB.TBL_Users.SingleOrDefault(s => s.Id == NewUserID);
                
                q.Password = Convert.ToBase64String(hashedpass);
                q.username = txt_username.Text;



                NewEntrance.UserName = txt_username.Text;
                NewEntrance.password = Convert.ToBase64String(hashedpass);
                NewEntrance.UserId= NewUserID;
                NewEntrance.RoleTypeId = 3013;
                myDB.TBL_Entrance.Add(NewEntrance);
                myDB.SaveChanges();

                
                    foreach (var item in gb_signup.Controls)
                    {
                        if (item is CTextBox)
                        {
                            ((CTextBox)item).Text = string.Empty;
                        }

                    }
                    foreach (var item in gb_UP.Controls)
                    {
                        if (item is CTextBox)
                        {
                            ((CTextBox)item).Text = string.Empty;
                        }
                        
                    }
                    

                

                MessageBox.Show("ثبت نام با موفقیت انجام شد");
                gb_signup.Visible = false;
                gb_login.Visible = true;
                txt_loginU.Focus();
                txt_loginPass.BackColor = Color.LightSalmon;

            }
            
            
                
            
        }

        private void txt_repass_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_repass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_repass.Text)
            {
                btn_newP.Visible = true;
                lbl_Passeror.Visible = false;
            }
            else
            {
                btn_newP.Visible = false;
                lbl_Passeror.Visible = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_repass.Text)
            {
                btn_newP.Visible = true;
                lbl_Passeror.Visible = false;
            }
            else
            {
                btn_newP.Visible = false;
                lbl_Passeror.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // to convert entry password into encrypted one to check in database:
            byte[] b = System.Text.Encoding.UTF8.GetBytes(txt_loginPass.Text);


            System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();

            byte[] Hashedpass = h.ComputeHash(b);

            var passwordd = Convert.ToBase64String(Hashedpass);
            var q = myDB.TBL_Entrance.Where(x =>x.password==passwordd & x.UserName == txt_loginU.Text & x.RoleTypeId == (int)cmb_RoleType.SelectedValue).ToList();
            //var q1 = myDB.TBL_Entrance.SingleOrDefault(x => x.RoleTypeId == (int)cmb_RoleType.SelectedValue);
            //  var checkrole=myDB.TBL_Entrance.SingleOrDefault(s=>s.RoleTypeId==(int)cmb_RoleType.SelectedValue);
            int role=(int)cmb_RoleType.SelectedValue;
            if (q.Count() == 0)
            {
                MessageBox.Show("Username or password is incorrect!");
            }
            else
            {
                datatransfer1.CurrentUserRole=role;
                if (role!=3013) {
                    MessageBox.Show("Successfull entry! Enjoy application...");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else { 
                        MessageBox.Show("wait for manegment to define your access level");
                }

            }
        
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            var q = myDB.TBL_Users.Where(s => s.username == txt_NcodeSignUp.Text).ToList();
            if (q.Count == 0)
            {
                
                lbl_Ueror.Visible = false;
                btn_newP.Visible =true;


             }
           else
            {
                
               lbl_Ueror.Visible = true;
                btn_newP.Visible = false;
            }
        }

        private void btn_changetologin_Click(object sender, EventArgs e)
        {
            gb_login.Visible = true;
            gb_signup.Visible = false;
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_test2_Click(object sender, EventArgs e)
        {
           
        }

        private void elGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gb_login_Enter(object sender, EventArgs e)
        {

        }

        private void gb_signup_Enter_1(object sender, EventArgs e)
        {

        }

        private void txt_loginU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}