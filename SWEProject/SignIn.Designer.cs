
namespace SWEProject
{
    partial class SignIn
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
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dr_rb = new System.Windows.Forms.RadioButton();
            this.pat_rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(274, 119);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(184, 22);
            this.email_txt.TabIndex = 0;
            this.email_txt.TextChanged += new System.EventHandler(this.email_txt_TextChanged);
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(274, 167);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(184, 22);
            this.pass_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dr_rb
            // 
            this.dr_rb.AutoSize = true;
            this.dr_rb.Location = new System.Drawing.Point(537, 143);
            this.dr_rb.Name = "dr_rb";
            this.dr_rb.Size = new System.Drawing.Size(111, 21);
            this.dr_rb.TabIndex = 10;
            this.dr_rb.TabStop = true;
            this.dr_rb.Text = "I am a doctor";
            this.dr_rb.UseVisualStyleBackColor = true;
            // 
            // pat_rb
            // 
            this.pat_rb.AutoSize = true;
            this.pat_rb.Checked = true;
            this.pat_rb.Location = new System.Drawing.Point(537, 116);
            this.pat_rb.Name = "pat_rb";
            this.pat_rb.Size = new System.Drawing.Size(114, 21);
            this.pat_rb.TabIndex = 9;
            this.pat_rb.TabStop = true;
            this.pat_rb.Text = "I am a patient";
            this.pat_rb.UseVisualStyleBackColor = true;
            this.pat_rb.CheckedChanged += new System.EventHandler(this.pat_rb_CheckedChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dr_rb);
            this.Controls.Add(this.pat_rb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.email_txt);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton dr_rb;
        private System.Windows.Forms.RadioButton pat_rb;
    }
}