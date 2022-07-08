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
    public partial class ViewAppointments : Form
    {
        OracleDataAdapter adapter;
        DataSet Ds;

        public ViewAppointments()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = " Data Source=orcl; User Id= scott; Password=tiger;";
            string cmdstr = " select distinct D.dname from Doctor D, Appointment app where app.pat_id =:pid ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("pid", CreateAccount.pat_id);

            Ds = new DataSet();
            adapter.Fill(Ds);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(Ds.Tables[0].Rows[i][0]);
            }
            string constr2 = " Data Source=orcl; User Id=scott; Password=tiger;";
            string cmdstr2 = " select  name ,  email , password from Patient where pat_id =:pid ";
            adapter = new OracleDataAdapter(cmdstr2, constr2);
            adapter.SelectCommand.Parameters.Add("pid", CreateAccount.pat_id);
            Ds = new DataSet();
            adapter.Fill(Ds);
            dataGridView1.DataSource = Ds.Tables[0];


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(Ds.Tables[0]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = " Data Source=orcl;User Id=scott ; Password=tiger ;";
            string cmdstr = " select D.dname,app.time from Doctor D, Appointment app where D.dr_id = app.dr_id and app.pat_id =:pid  ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("pid", CreateAccount.pat_id);
            Ds = new DataSet();
            adapter.Fill(Ds);
            dataGridView2.DataSource = Ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string cmdstr = " select D.dname , app.time , p.name from Doctor D, Appointment app, Patient p where  app.pat_id =:pid and app.pat_id = p.pat_id and D.dname =:dName and D.dr_id=app.dr_id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("pid", CreateAccount.pat_id);
            adapter.SelectCommand.Parameters.Add("dName", comboBox1.SelectedItem.ToString());
            Ds = new DataSet();
            adapter.Fill(Ds);
            dataGridView2.DataSource = Ds.Tables[0];
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BookAppt v = new BookAppt();
            v.Show();
            this.Hide();
        }
    }
}
 