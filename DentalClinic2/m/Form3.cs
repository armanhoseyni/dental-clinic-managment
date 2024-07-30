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
    public partial class frm_sn : Form
    {
        public frm_sn()
        {
            InitializeComponent();
        }

        private void btn_chekSn_Click(object sender, EventArgs e)
        {
            if (txt_sn.Text=="123456789")
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\myapp", "sn",txt_sn.Text);
                MessageBox.Show(" main version activated");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("wrong serial number");

            }
        }

        private void frm_sn_Load(object sender, EventArgs e)
        {

        }
    }
}
