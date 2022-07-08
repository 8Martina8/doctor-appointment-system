


namespace SWEProject
{
    partial class BookAppt
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
            this.timeslots_gridview = new System.Windows.Forms.DataGridView();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefilter_btn = new System.Windows.Forms.Button();
            this.apptdate_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.book_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeslots_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // timeslots_gridview
            // 
            this.timeslots_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeslots_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSlot});
            this.timeslots_gridview.Location = new System.Drawing.Point(131, 125);
            this.timeslots_gridview.Name = "timeslots_gridview";
            this.timeslots_gridview.RowHeadersWidth = 51;
            this.timeslots_gridview.RowTemplate.Height = 25;
            this.timeslots_gridview.Size = new System.Drawing.Size(339, 247);
            this.timeslots_gridview.TabIndex = 0;
            this.timeslots_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TimeSlot
            // 
            this.TimeSlot.DataPropertyName = "time";
            this.TimeSlot.HeaderText = "Time Slots";
            this.TimeSlot.MinimumWidth = 6;
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.ReadOnly = true;
            this.TimeSlot.Width = 125;
            // 
            // datefilter_btn
            // 
            this.datefilter_btn.Location = new System.Drawing.Point(255, 94);
            this.datefilter_btn.Name = "datefilter_btn";
            this.datefilter_btn.Size = new System.Drawing.Size(81, 25);
            this.datefilter_btn.TabIndex = 2;
            this.datefilter_btn.Text = "search";
            this.datefilter_btn.UseVisualStyleBackColor = true;
            this.datefilter_btn.Click += new System.EventHandler(this.datefilter_btn_Click);
            // 
            // apptdate_picker
            // 
            this.apptdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.apptdate_picker.Location = new System.Drawing.Point(186, 59);
            this.apptdate_picker.Name = "apptdate_picker";
            this.apptdate_picker.Size = new System.Drawing.Size(228, 22);
            this.apptdate_picker.TabIndex = 3;
            this.apptdate_picker.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            this.apptdate_picker.ValueChanged += new System.EventHandler(this.apptdate_picker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter appointment date:";
            // 
            // book_btn
            // 
            this.book_btn.Location = new System.Drawing.Point(216, 387);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(160, 25);
            this.book_btn.TabIndex = 5;
            this.book_btn.Text = "Book Appointment";
            this.book_btn.UseVisualStyleBackColor = true;
            this.book_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 402);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(86, 25);
            this.back_btn.TabIndex = 20;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // BookAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 439);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apptdate_picker);
            this.Controls.Add(this.datefilter_btn);
            this.Controls.Add(this.timeslots_gridview);
            this.Name = "BookAppt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeslots_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timeslots_gridview;
        private System.Windows.Forms.Button datefilter_btn;
        private System.Windows.Forms.DateTimePicker apptdate_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button book_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private System.Windows.Forms.Button back_btn;
    }
}