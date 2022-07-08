namespace SWEProject
{
    partial class CreateAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.pat_rb = new System.Windows.Forms.RadioButton();
            this.dr_rb = new System.Windows.Forms.RadioButton();
            this.specialty_label = new System.Windows.Forms.Label();
            this.starttime_label = new System.Windows.Forms.Label();
            this.endtime_label = new System.Windows.Forms.Label();
            this.aptdur_label = new System.Windows.Forms.Label();
            this.starttime_txt = new System.Windows.Forms.TextBox();
            this.endtime_txt = new System.Windows.Forms.TextBox();
            this.specialty_cmb = new System.Windows.Forms.ComboBox();
            this.aptdur_updown = new System.Windows.Forms.NumericUpDown();
            this.creataccount_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aptdur_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.Location = new System.Drawing.Point(161, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(133, 73);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(357, 22);
            this.name_txt.TabIndex = 4;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(133, 110);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(357, 22);
            this.email_txt.TabIndex = 5;
            this.email_txt.Validating += new System.ComponentModel.CancelEventHandler(this.email_txt_Validating);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(133, 145);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(357, 22);
            this.password_txt.TabIndex = 6;
            // 
            // pat_rb
            // 
            this.pat_rb.AutoSize = true;
            this.pat_rb.Location = new System.Drawing.Point(51, 188);
            this.pat_rb.Name = "pat_rb";
            this.pat_rb.Size = new System.Drawing.Size(114, 21);
            this.pat_rb.TabIndex = 7;
            this.pat_rb.TabStop = true;
            this.pat_rb.Text = "I am a patient";
            this.pat_rb.UseVisualStyleBackColor = true;
            this.pat_rb.CheckedChanged += new System.EventHandler(this.pat_rb_CheckedChanged);
            // 
            // dr_rb
            // 
            this.dr_rb.AutoSize = true;
            this.dr_rb.Location = new System.Drawing.Point(51, 214);
            this.dr_rb.Name = "dr_rb";
            this.dr_rb.Size = new System.Drawing.Size(111, 21);
            this.dr_rb.TabIndex = 8;
            this.dr_rb.TabStop = true;
            this.dr_rb.Text = "I am a doctor";
            this.dr_rb.UseVisualStyleBackColor = true;
            this.dr_rb.CheckedChanged += new System.EventHandler(this.dr_rb_CheckedChanged);
            // 
            // specialty_label
            // 
            this.specialty_label.AutoSize = true;
            this.specialty_label.Location = new System.Drawing.Point(211, 222);
            this.specialty_label.Name = "specialty_label";
            this.specialty_label.Size = new System.Drawing.Size(65, 17);
            this.specialty_label.TabIndex = 9;
            this.specialty_label.Text = "Specialty";
            this.specialty_label.Click += new System.EventHandler(this.specialty_label_Click);
            // 
            // starttime_label
            // 
            this.starttime_label.AutoSize = true;
            this.starttime_label.Location = new System.Drawing.Point(211, 254);
            this.starttime_label.Name = "starttime_label";
            this.starttime_label.Size = new System.Drawing.Size(73, 17);
            this.starttime_label.TabIndex = 10;
            this.starttime_label.Text = "Start Time";
            this.starttime_label.Click += new System.EventHandler(this.starttime_label_Click);
            // 
            // endtime_label
            // 
            this.endtime_label.AutoSize = true;
            this.endtime_label.Location = new System.Drawing.Point(211, 286);
            this.endtime_label.Name = "endtime_label";
            this.endtime_label.Size = new System.Drawing.Size(68, 17);
            this.endtime_label.TabIndex = 11;
            this.endtime_label.Text = "End Time";
            this.endtime_label.Click += new System.EventHandler(this.endtime_label_Click);
            // 
            // aptdur_label
            // 
            this.aptdur_label.AutoSize = true;
            this.aptdur_label.Location = new System.Drawing.Point(211, 311);
            this.aptdur_label.Name = "aptdur_label";
            this.aptdur_label.Size = new System.Drawing.Size(145, 17);
            this.aptdur_label.TabIndex = 12;
            this.aptdur_label.Text = "Appointment Duration";
            this.aptdur_label.Click += new System.EventHandler(this.aptdur_label_Click);
            // 
            // starttime_txt
            // 
            this.starttime_txt.Location = new System.Drawing.Point(376, 247);
            this.starttime_txt.MaxLength = 5;
            this.starttime_txt.Name = "starttime_txt";
            this.starttime_txt.Size = new System.Drawing.Size(114, 22);
            this.starttime_txt.TabIndex = 13;
            this.starttime_txt.TextChanged += new System.EventHandler(this.starttime_txt_TextChanged);
            // 
            // endtime_txt
            // 
            this.endtime_txt.Location = new System.Drawing.Point(376, 278);
            this.endtime_txt.MaxLength = 5;
            this.endtime_txt.Name = "endtime_txt";
            this.endtime_txt.Size = new System.Drawing.Size(114, 22);
            this.endtime_txt.TabIndex = 14;
            this.endtime_txt.TextChanged += new System.EventHandler(this.endtime_txt_TextChanged);
            // 
            // specialty_cmb
            // 
            this.specialty_cmb.FormattingEnabled = true;
            this.specialty_cmb.Location = new System.Drawing.Point(376, 219);
            this.specialty_cmb.Name = "specialty_cmb";
            this.specialty_cmb.Size = new System.Drawing.Size(138, 24);
            this.specialty_cmb.TabIndex = 15;
            this.specialty_cmb.SelectedIndexChanged += new System.EventHandler(this.specialty_cmb_SelectedIndexChanged);
            // 
            // aptdur_updown
            // 
            this.aptdur_updown.Location = new System.Drawing.Point(377, 309);
            this.aptdur_updown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.aptdur_updown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.aptdur_updown.Name = "aptdur_updown";
            this.aptdur_updown.Size = new System.Drawing.Size(113, 22);
            this.aptdur_updown.TabIndex = 16;
            this.aptdur_updown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.aptdur_updown.ValueChanged += new System.EventHandler(this.aptdur_updown_ValueChanged);
            // 
            // creataccount_btn
            // 
            this.creataccount_btn.Location = new System.Drawing.Point(234, 348);
            this.creataccount_btn.Name = "creataccount_btn";
            this.creataccount_btn.Size = new System.Drawing.Size(122, 25);
            this.creataccount_btn.TabIndex = 17;
            this.creataccount_btn.Text = "Create Account";
            this.creataccount_btn.UseVisualStyleBackColor = true;
            this.creataccount_btn.Click += new System.EventHandler(this.creataccount_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(31, 348);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(86, 25);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 185);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Appointment Fee";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.creataccount_btn);
            this.Controls.Add(this.aptdur_updown);
            this.Controls.Add(this.specialty_cmb);
            this.Controls.Add(this.endtime_txt);
            this.Controls.Add(this.starttime_txt);
            this.Controls.Add(this.aptdur_label);
            this.Controls.Add(this.endtime_label);
            this.Controls.Add(this.starttime_label);
            this.Controls.Add(this.specialty_label);
            this.Controls.Add(this.dr_rb);
            this.Controls.Add(this.pat_rb);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptdur_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.RadioButton pat_rb;
        private System.Windows.Forms.RadioButton dr_rb;
        private System.Windows.Forms.Label specialty_label;
        private System.Windows.Forms.Label starttime_label;
        private System.Windows.Forms.Label endtime_label;
        private System.Windows.Forms.Label aptdur_label;
        private System.Windows.Forms.TextBox starttime_txt;
        private System.Windows.Forms.TextBox endtime_txt;
        private System.Windows.Forms.ComboBox specialty_cmb;
        private System.Windows.Forms.NumericUpDown aptdur_updown;
        private System.Windows.Forms.Button creataccount_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}