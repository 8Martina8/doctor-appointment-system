using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text.RegularExpressions;






namespace SWEProject
{
    public partial class CreateAccount : Form
    {
        public static int pat_id=-1;
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            // at start make doctor details invisible
            label5.Visible = false;
            textBox1.Visible = false;
            endtime_label.Visible = false;
            starttime_label.Visible = false;
            specialty_label.Visible = false;
            aptdur_label.Visible = false;
            starttime_txt.Visible = false;
            endtime_txt.Visible = false;
            aptdur_updown.Visible = false;
            specialty_cmb.Visible = false;  
            
            pat_rb.Checked = true;

            String[] specialtyArr = {"Dermatology", "Pediatrics", "Ophthalmology", "Psychiatry" , "Internal Medicine", "Orthopedics", "Radiology"};
            foreach(String specialty in specialtyArr)
            {
                specialty_cmb.Items.Add(specialty);
            }
        }

        private void creataccount_btn_Click(object sender, EventArgs e)
        {
            string pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

            if (!Regex.Match(email_txt.Text, pattern).Success)
            {
                MessageBox.Show("Invalid Email");
                email_txt.Focus();
                return;
            }
            


            int id;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (pat_rb.Checked)
            {
                cmd.CommandText = "getPatId";
            }
            else if (dr_rb.Checked)
            {
                cmd.CommandText = "getDrId";
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                id = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
            }
            catch
            {
                id = 1;
            }

            //check if account exists
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            if (pat_rb.Checked)
            {
                cmd2.CommandText = "select pat_id from patient where email = :email";
                cmd2.Parameters.Add("email", email_txt.Text);
            }
            else if (dr_rb.Checked)
            {
                cmd2.CommandText = "select dr_id from doctor where email = :email";
                cmd2.Parameters.Add("email", email_txt.Text);
            }
            OracleDataReader dr = cmd2.ExecuteReader(); 
            
            if (dr.Read())
            {
                MessageBox.Show("There is an account with the same email address");
            }
            else
            {
                //add account
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;

                if (pat_rb.Checked)
                {
                    cmd3.CommandText = "insert into patient values(:id, :name,:email,:password)";
                    cmd3.Parameters.Add("id", id);
                    cmd3.Parameters.Add("name", name_txt.Text);
                    cmd3.Parameters.Add("email", email_txt.Text);
                    cmd3.Parameters.Add("password", password_txt.Text);


                }
                else if (dr_rb.Checked)
                {
                    string pattern2 = "^([0-1][0-9]|[2][0-3]):([0-5][0-9])$";
                    if (!Regex.Match(starttime_txt.Text, pattern2).Success)
                    {
                        MessageBox.Show("Invalid Time Format");
                        starttime_txt.Focus();
                        return;
                    }
                    if (!Regex.Match(endtime_txt.Text, pattern2).Success)
                    {
                        MessageBox.Show("Invalid Time Format");
                        endtime_txt.Focus();
                        return;
                    }
                    SignIn.isDoctor = true;
                    string st = starttime_txt.Text;
                    string et = endtime_txt.Text;
                    // convert start time string to int
                    double startHour = double.Parse(st[0].ToString() + st[1].ToString());
                    double startMinute = (double.Parse(st[3].ToString() + st[4].ToString())) / 60;
                    // convert end time string to int
                    double endHour = double.Parse(et[0].ToString() + et[1].ToString());
                    double endMinute =(double.Parse(et[3].ToString() + et[4].ToString()))/ 60;
                    double startTime, endTime;

                    startTime = (startHour + startMinute) / 24;
                    endTime = (endHour + endMinute) / 24;
                   



                    cmd3.CommandText = "insert into doctor values(:id,:name,:email, :specialty ,:password,trunc(sysdate) +:startTime, trunc(sysdate) + :endTime, :duration,:fee)";
                    cmd3.Parameters.Add("id", id);
                    cmd3.Parameters.Add("name", name_txt.Text);
                    cmd3.Parameters.Add("email", email_txt.Text);
                    cmd3.Parameters.Add("password", password_txt.Text);
                    cmd3.Parameters.Add("specialty", specialty_cmb.SelectedItem.ToString());
                    cmd3.Parameters.Add("startTime", startTime);
                    cmd3.Parameters.Add("endTime", endTime);
                    cmd3.Parameters.Add("duration", aptdur_updown.Value);
                    cmd3.Parameters.Add("fee", textBox1.Text);
                }

                int r = cmd3.ExecuteNonQuery();
                if (r != -1)
                {
                    DialogResult result = MessageBox.Show("Account Added");
                    if (result == DialogResult.OK)
                    {
                        if (pat_rb.Checked)
                        {
                            pat_id = id;
                            ChooseSpecialty b = new ChooseSpecialty();
                            SignIn.isDoctor = false;
                            b.Show();
                            this.Hide();

                        }
                        else if (dr_rb.Checked)
                        {
                            SignIn.isDoctor = true;
                            ChooseSpecialty.docid = id;
                            DoctorInfo b = new DoctorInfo();
                            b.Show();
                            this.Hide();
                        }
                    }
                }
            }
            //dr.Close();
        }

        private void pat_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (pat_rb.Checked)
            {
                label5.Visible = false;
                textBox1.Visible = false;
                endtime_label.Visible = false;
                starttime_label.Visible = false;
                specialty_label.Visible = false;
                aptdur_label.Visible = false;
                starttime_txt.Visible = false;
                endtime_txt.Visible = false;
                aptdur_updown.Visible = false;
                specialty_cmb.Visible = false;
            }
        }

        private void dr_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(dr_rb.Checked)
            {
                label5.Visible = true;
                textBox1.Visible = true;
                endtime_label.Visible = true;
                starttime_label.Visible = true;
                specialty_label.Visible = true;
                aptdur_label.Visible = true;
                starttime_txt.Visible = true;
                endtime_txt.Visible = true;
                aptdur_updown.Visible = true;
                specialty_cmb.Visible = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void aptdur_updown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void specialty_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endtime_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void starttime_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void aptdur_label_Click(object sender, EventArgs e)
        {

        }

        private void endtime_label_Click(object sender, EventArgs e)
        {

        }

        private void starttime_label_Click(object sender, EventArgs e)
        {

        }

        private void specialty_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txt_Validating(object sender, CancelEventArgs e)
        {

        }
    }   
}