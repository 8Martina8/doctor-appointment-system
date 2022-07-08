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
    public partial class DoctorChangePass : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public DoctorChangePass()
        {
            InitializeComponent();
        }

        private void updateaccount_btn_Click(object sender, EventArgs e)
        {


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select dr_id from doctor where password=:pass and dr_id=:docid ";
            cmd.Parameters.Add("pass", textBox1.Text);
            cmd.Parameters.Add("docid", ChooseSpecialty.docid);

            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {

                MessageBox.Show("Old Password is incorrect!");


            }
            else
            {
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "update doctor set password=:pass where dr_id=:docid";
                cmd3.Parameters.Add("pass", password_txt.Text);
                cmd3.Parameters.Add("docid", ChooseSpecialty.docid);

                cmd3.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Password Updated Successfully!");
                if (result == DialogResult.OK)
                {

                    DoctorInfo d = new DoctorInfo();
                    d.Show();
                    this.Hide();

                }
            }

        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
