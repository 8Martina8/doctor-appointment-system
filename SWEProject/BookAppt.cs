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
    public partial class BookAppt : Form
    {
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public BookAppt()
        {
           
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "select time from timeslot where time >= trunc(sysdate) and dr_id = :dr_id and isavailable = 'Y' ";
            cmd.Parameters.Add("dr_id", ChooseSpecialty.docid);

            OracleDataReader dr = cmd.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //timeslots_gridview.Columns.Add("Time Slot");
            while (dr.Read())
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                dgvRow.Cells[0].Value = dr[0];
                timeslots_gridview.Rows.Add(dgvRow);
            }
           

     
            //timeslots_gridview.DataSource = dataTable;

        }

        private void datefilter_btn_Click(object sender, EventArgs e)
        {
            apptdate_picker.CustomFormat = "dd/MM/yy";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        
            String tomdate = apptdate_picker.Value.AddDays(1).ToString("dd/MM/yy");
       

            cmd.CommandText = "select time from timeslot where time >= TO_DATE(:mydate, 'dd/MM/yy' ) and time< TO_DATE(:tomdate, 'dd/MM/yy' ) and dr_id = :dr_id and isavailable = 'Y' ";
            
            cmd.Parameters.Add("mydate", apptdate_picker.Text);
            cmd.Parameters.Add("tomdate", tomdate);
            cmd.Parameters.Add("dr_id", ChooseSpecialty.docid);

            OracleDataReader dr = cmd.ExecuteReader();

            timeslots_gridview.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                dgvRow.Cells[0].Value = dr[0];
                timeslots_gridview.Rows.Add(dgvRow);
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "bookApt";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("did", ChooseSpecialty.docid);
            cmd.Parameters.Add("pid", CreateAccount.pat_id);
            cmd.Parameters.Add("times", timeslots_gridview.CurrentCell.Value);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Appointment Booked Successfully");
            //conn.Close();
            ViewAppointments v = new ViewAppointments();
            v.Show();
            this.Hide();
        
        }

        private void apptdate_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            DoctorInfo d = new DoctorInfo();
            d.Show();
            this.Hide();
        }
    }
}