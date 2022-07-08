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
    public partial class SignIn : Form
    {
        public static bool isDoctor;
        string ordb ="Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (pat_rb.Checked)
            {
                cmd.CommandText = "select pat_id from patient where email=:email and password=:pass";
                cmd.Parameters.Add("email", email_txt.Text);
                cmd.Parameters.Add("pass", pass_txt.Text);
            }
            else if (dr_rb.Checked)
            {
                cmd.CommandText = "select dr_id from doctor where email=:email and password=:pass";
                cmd.Parameters.Add("email", email_txt.Text);
                cmd.Parameters.Add("pass", pass_txt.Text);
            }
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (pat_rb.Checked)
                {
                    CreateAccount.pat_id = Convert.ToInt32(dr[0].ToString());
                    ChooseSpecialty b = new ChooseSpecialty();
                    b.Show();
                    this.Hide();

                }
                else if (dr_rb.Checked)
                {
                    isDoctor = true;
                    ChooseSpecialty.docid = Convert.ToInt32(dr[0].ToString());
                    DoctorInfo b = new DoctorInfo();
                    b.Show();
                    this.Hide();
                }
                


            }

            else
            {
                MessageBox.Show("Invalid email or password");
            }
            //dr.Close();
            //conn.Close();
        }
        
        private void SignIn_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void pat_rb_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
