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
    public partial class Form2 : Form
    {
        List<string> deptlist = new List<string>()
        {
            "HR","admin","Manager","Sales","devlopemnt","testing","marketing"
        };
        private void Form2_Load(object sender, EventArgs e)
        {
            combodept.DataSource = deptlist;
        }
        public Form2()
        {
            InitializeComponent();
        }

   

       /* private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
       */
      

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToInt32(txtbasicsalary.Text);
                double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs+hra+ta+da) - pf;

            txthra.Text = hra.ToString();
            txtta.Text = ta.ToString();
            txtda.Text = da.ToString();
            txtpf.Text = pf.ToString();

            txtgross.Text = gross.ToString();
;
        }
        private void btndisplay_Click(object sender, EventArgs e)
        {
            string msg = txtempid.Text + " \n" + txtempname.Text + " \n" + combodept.Text + " \n"
                + txtbasicsalary.Text + " \n" + txtgross.Text;

            lblmsg.Text = msg;
        }



        private void txtgross_TextChanged(object sender, EventArgs e)
        {

        }
        private void labl_da_Click(object sender, EventArgs e)
        {

        }

        private void lblta_Click(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
