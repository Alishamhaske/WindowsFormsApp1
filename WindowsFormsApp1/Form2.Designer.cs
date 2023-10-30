namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_Basic_salary = new System.Windows.Forms.Label();
            this.lbl_hra = new System.Windows.Forms.Label();
            this.labl_da = new System.Windows.Forms.Label();
            this.lbl_pf = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.txthra = new System.Windows.Forms.TextBox();
            this.txtda = new System.Windows.Forms.TextBox();
            this.combodept = new System.Windows.Forms.ComboBox();
            this.txtpf = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblta = new System.Windows.Forms.Label();
            this.txtta = new System.Windows.Forms.TextBox();
            this.lblgross = new System.Windows.Forms.Label();
            this.txtgross = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(82, 51);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(42, 13);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "Emp_id";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(82, 99);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(57, 13);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Emp name";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Location = new System.Drawing.Point(82, 147);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(62, 13);
            this.lbl_dept.TabIndex = 2;
            this.lbl_dept.Text = "Department";
            // 
            // lbl_Basic_salary
            // 
            this.lbl_Basic_salary.AutoSize = true;
            this.lbl_Basic_salary.Location = new System.Drawing.Point(82, 196);
            this.lbl_Basic_salary.Name = "lbl_Basic_salary";
            this.lbl_Basic_salary.Size = new System.Drawing.Size(65, 13);
            this.lbl_Basic_salary.TabIndex = 3;
            this.lbl_Basic_salary.Text = "Basic Salary";
            // 
            // lbl_hra
            // 
            this.lbl_hra.AutoSize = true;
            this.lbl_hra.Location = new System.Drawing.Point(82, 235);
            this.lbl_hra.Name = "lbl_hra";
            this.lbl_hra.Size = new System.Drawing.Size(30, 13);
            this.lbl_hra.TabIndex = 4;
            this.lbl_hra.Text = "HRA";
            // 
            // labl_da
            // 
            this.labl_da.AutoSize = true;
            this.labl_da.Location = new System.Drawing.Point(83, 309);
            this.labl_da.Name = "labl_da";
            this.labl_da.Size = new System.Drawing.Size(22, 13);
            this.labl_da.TabIndex = 5;
            this.labl_da.Text = "DA";
            this.labl_da.Click += new System.EventHandler(this.labl_da_Click);
            // 
            // lbl_pf
            // 
            this.lbl_pf.AutoSize = true;
            this.lbl_pf.Location = new System.Drawing.Point(83, 348);
            this.lbl_pf.Name = "lbl_pf";
            this.lbl_pf.Size = new System.Drawing.Size(20, 13);
            this.lbl_pf.TabIndex = 6;
            this.lbl_pf.Text = "PF";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(191, 51);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(121, 20);
            this.txtempid.TabIndex = 7;
            this.txtempid.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(191, 99);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(121, 20);
            this.txtempname.TabIndex = 8;
            this.txtempname.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Location = new System.Drawing.Point(191, 189);
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(121, 20);
            this.txtbasicsalary.TabIndex = 9;
            // 
            // txthra
            // 
            this.txthra.Location = new System.Drawing.Point(190, 228);
            this.txthra.Name = "txthra";
            this.txthra.ReadOnly = true;
            this.txthra.Size = new System.Drawing.Size(121, 20);
            this.txthra.TabIndex = 10;
            // 
            // txtda
            // 
            this.txtda.Location = new System.Drawing.Point(190, 302);
            this.txtda.Name = "txtda";
            this.txtda.ReadOnly = true;
            this.txtda.Size = new System.Drawing.Size(121, 20);
            this.txtda.TabIndex = 11;
            // 
            // combodept
            // 
            this.combodept.FormattingEnabled = true;
            this.combodept.Location = new System.Drawing.Point(191, 147);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(121, 21);
            this.combodept.TabIndex = 12;
            // 
            // txtpf
            // 
            this.txtpf.Location = new System.Drawing.Point(191, 341);
            this.txtpf.Name = "txtpf";
            this.txtpf.ReadOnly = true;
            this.txtpf.Size = new System.Drawing.Size(121, 20);
            this.txtpf.TabIndex = 13;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncalculate.Location = new System.Drawing.Point(85, 410);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 14;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndisplay.Location = new System.Drawing.Point(227, 410);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 15;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(348, 106);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(61, 13);
            this.lblmsg.TabIndex = 17;
            this.lblmsg.Text = "Emp details";
            // 
            // lblta
            // 
            this.lblta.AutoSize = true;
            this.lblta.Location = new System.Drawing.Point(83, 271);
            this.lblta.Name = "lblta";
            this.lblta.Size = new System.Drawing.Size(21, 13);
            this.lblta.TabIndex = 18;
            this.lblta.Text = "TA";
            this.lblta.Click += new System.EventHandler(this.lblta_Click);
            // 
            // txtta
            // 
            this.txtta.Location = new System.Drawing.Point(191, 268);
            this.txtta.Name = "txtta";
            this.txtta.ReadOnly = true;
            this.txtta.Size = new System.Drawing.Size(120, 20);
            this.txtta.TabIndex = 19;
            // 
            // lblgross
            // 
            this.lblgross.AutoSize = true;
            this.lblgross.Location = new System.Drawing.Point(80, 385);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(64, 13);
            this.lblgross.TabIndex = 20;
            this.lblgross.Text = "Gross salary";
            // 
            // txtgross
            // 
            this.txtgross.Location = new System.Drawing.Point(191, 378);
            this.txtgross.Name = "txtgross";
            this.txtgross.ReadOnly = true;
            this.txtgross.Size = new System.Drawing.Size(121, 20);
            this.txtgross.TabIndex = 21;
            this.txtgross.TextChanged += new System.EventHandler(this.txtgross_TextChanged);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(441, 618);
            this.Controls.Add(this.txtgross);
            this.Controls.Add(this.lblgross);
            this.Controls.Add(this.txtta);
            this.Controls.Add(this.lblta);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpf);
            this.Controls.Add(this.combodept);
            this.Controls.Add(this.txtda);
            this.Controls.Add(this.txthra);
            this.Controls.Add(this.txtbasicsalary);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lbl_pf);
            this.Controls.Add(this.labl_da);
            this.Controls.Add(this.lbl_hra);
            this.Controls.Add(this.lbl_Basic_salary);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemp_id;
        private System.Windows.Forms.Label llblemp_name;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblbasic_salary;
        private System.Windows.Forms.Label lblhra;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.Label lblpf;
        private System.Windows.Forms.Label lblgross_salary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_Basic_salary;
        private System.Windows.Forms.Label lbl_hra;
        private System.Windows.Forms.Label labl_da;
        private System.Windows.Forms.Label lbl_pf;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.TextBox txthra;
        private System.Windows.Forms.TextBox txtda;
        private System.Windows.Forms.ComboBox combodept;
        private System.Windows.Forms.TextBox txtpf;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblta;
        private System.Windows.Forms.TextBox txtta;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.TextBox txtgross;
    }
}