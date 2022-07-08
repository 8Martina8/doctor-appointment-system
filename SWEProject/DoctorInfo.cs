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



namespace SWEProject
{
    public partial class DoctorInfo : Form
    {
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (SignIn.isDoctor==true)
            {
                
                bookform_btn.Visible = false;
                back_btn.Visible = true;
                back_btn.Text = "Back to Main Page";
            }
            else
            {
                back_btn.Visible = true;
                button1.Visible = false;
            }
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectDr";
            /*
             create or replace procedure selectDr (did number , name out VARCHAR2(20), specialty out VARCHAR2(30) , startTime out TIMESTAMP,
            endTime out TIMESTAMP, apptdur out NUMBER(2) )
            as
            begin
            select name, specialty, startTime,endTime aptdur
            from doctor
            where dr_id = did;
            end procedure;
             */
            
            cmd.Parameters.Add("drid", ChooseSpecialty.docid);
            cmd.Parameters.Add("name", OracleDbType.Varchar2, 100, null, ParameterDirection.Output);
            cmd.Parameters.Add("specialty", OracleDbType.Varchar2, 100, null, ParameterDirection.Output);
            cmd.Parameters.Add("starttime", OracleDbType.TimeStamp, ParameterDirection.Output);
            cmd.Parameters.Add("endtime", OracleDbType.TimeStamp, ParameterDirection.Output);
            cmd.Parameters.Add("dur", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("fee", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            drname_label.Text = cmd.Parameters["name"].Value.ToString();
            specialty_label.Text = cmd.Parameters["specialty"].Value.ToString();

            String st = cmd.Parameters["starttime"].Value.ToString().Substring(10, 5)+ cmd.Parameters["starttime"].Value.ToString().Substring(28, 3);
            String et = cmd.Parameters["endtime"].Value.ToString().Substring(10, 5) + cmd.Parameters["endtime"].Value.ToString().Substring(28, 3);

            hours_label.Text = st + " to " + et;
            dur_label.Text = cmd.Parameters["dur"].Value.ToString();
            label4.Text= cmd.Parameters["fee"].Value.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bookform_btn_Click(object sender, EventArgs e)
        {
            //conn.Close();
            BookAppt b = new BookAppt();
            b.Show();
            this.Hide();
        }

        private void drname_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorChangePass u = new DoctorChangePass();
            u.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (SignIn.isDoctor == true)
            {
                MainForm c = new MainForm();
                c.Show();
                this.Hide();
            }
            else
            {
                ChooseSpecialty c = new ChooseSpecialty();
                c.Show();
                this.Hide();
            }
        }
    }
}