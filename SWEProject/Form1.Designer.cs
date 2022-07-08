
namespace SWEProject
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 122);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1193, 499);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // startdate
            // 
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startdate.Location = new System.Drawing.Point(704, 37);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(141, 22);
            this.startdate.TabIndex = 4;
            this.startdate.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose Appointment Date Range:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Doctor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // enddate
            // 
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate.Location = new System.Drawing.Point(948, 37);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(141, 22);
            this.enddate.TabIndex = 13;
            this.enddate.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "End Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(22, 91);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(150, 25);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Back to Main Page";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 686);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
    }
}