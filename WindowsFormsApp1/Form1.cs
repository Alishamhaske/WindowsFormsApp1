using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
              
                MessageBox.Show("Login sucessfully ");
                txtusername.Clear();
                txtpassword.Clear();
                mdiform mobj = new mdiform();
                mobj.Show();
              
               /* Form2 form2 = new Form2();
                form2.Show();*/
                this.Hide();

            }
            else
            {
                MessageBox.Show( "Login Fail");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();


        }
    }
}
