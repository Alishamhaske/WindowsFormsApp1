﻿using System;
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
    public partial class mdiform : Form
    {
        public mdiform()
        {
            InitializeComponent();
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad noteobj = new notepad();
            noteobj.MdiParent = this;
            noteobj.Show();
        }
    }
}
