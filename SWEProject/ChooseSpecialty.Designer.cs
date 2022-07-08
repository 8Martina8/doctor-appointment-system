
namespace SWEProject
{
    partial class ChooseSpecialty
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
            this.cmb_sp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.docID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_sp
            // 
            this.cmb_sp.BackColor = System.Drawing.Color.White;
            this.cmb_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sp.FormattingEnabled = true;
            this.cmb_sp.Location = new System.Drawing.Point(394, 57);
            this.cmb_sp.Name = "cmb_sp";
            this.cmb_sp.Size = new System.Drawing.Size(249, 24);
            this.cmb_sp.TabIndex = 0;
            this.cmb_sp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docID,
            this.docName,
            this.view});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 321);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // docID
            // 
            this.docID.DataPropertyName = "dr_id";
            this.docID.HeaderText = "Doctor ID";
            this.docID.MinimumWidth = 6;
            this.docID.Name = "docID";
            this.docID.ReadOnly = true;
            // 
            // docName
            // 
            this.docName.DataPropertyName = "dName";
            this.docName.HeaderText = "Doctor Name";
            this.docName.MinimumWidth = 6;
            this.docName.Name = "docName";
            this.docName.ReadOnly = true;
            // 
            // view
            // 
            this.view.HeaderText = "View Doctor Info";
            this.view.MinimumWidth = 6;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Doctor\'s Specialty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(12, 461);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(181, 25);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "Go Back to Main Page";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ChooseSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_sp);
            this.Name = "ChooseSpecialty";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ChooseSpecialty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_sp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn docID;
        private System.Windows.Forms.DataGridViewTextBoxColumn docName;
        private System.Windows.Forms.DataGridViewButtonColumn view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}