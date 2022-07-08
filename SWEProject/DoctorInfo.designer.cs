namespace SWEProject
{
    partial class DoctorInfo
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
            this.drname_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialty_label = new System.Windows.Forms.Label();
            this.dur_label = new System.Windows.Forms.Label();
            this.hours_label = new System.Windows.Forms.Label();
            this.bookform_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drname_label
            // 
            this.drname_label.AutoSize = true;
            this.drname_label.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.drname_label.Location = new System.Drawing.Point(75, 28);
            this.drname_label.Name = "drname_label";
            this.drname_label.Size = new System.Drawing.Size(274, 41);
            this.drname_label.TabIndex = 0;
            this.drname_label.Text = "Doctor Name Label";
            this.drname_label.Click += new System.EventHandler(this.drname_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specialty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(54, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Working Hours";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Appointment Duration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // specialty_label
            // 
            this.specialty_label.AutoSize = true;
            this.specialty_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialty_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.specialty_label.Location = new System.Drawing.Point(242, 113);
            this.specialty_label.Name = "specialty_label";
            this.specialty_label.Size = new System.Drawing.Size(69, 20);
            this.specialty_label.TabIndex = 4;
            this.specialty_label.Text = "Specialty";
            // 
            // dur_label
            // 
            this.dur_label.AutoSize = true;
            this.dur_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dur_label.Location = new System.Drawing.Point(243, 173);
            this.dur_label.Name = "dur_label";
            this.dur_label.Size = new System.Drawing.Size(145, 17);
            this.dur_label.TabIndex = 6;
            this.dur_label.Text = "Appointment Duration";
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hours_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hours_label.Location = new System.Drawing.Point(243, 144);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(107, 20);
            this.hours_label.TabIndex = 5;
            this.hours_label.Text = "Working Hours";
            // 
            // bookform_btn
            // 
            this.bookform_btn.Location = new System.Drawing.Point(363, 261);
            this.bookform_btn.Name = "bookform_btn";
            this.bookform_btn.Size = new System.Drawing.Size(159, 25);
            this.bookform_btn.TabIndex = 7;
            this.bookform_btn.Text = "Proceed to Booking";
            this.bookform_btn.UseVisualStyleBackColor = true;
            this.bookform_btn.Click += new System.EventHandler(this.bookform_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(244, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Appointment Fee";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 329);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(173, 25);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 366);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookform_btn);
            this.Controls.Add(this.dur_label);
            this.Controls.Add(this.hours_label);
            this.Controls.Add(this.specialty_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drname_label);
            this.Name = "DoctorInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drname_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label specialty_label;
        private System.Windows.Forms.Label dur_label;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Button bookform_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_btn;
    }
}