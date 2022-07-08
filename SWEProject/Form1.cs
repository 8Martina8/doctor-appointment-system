using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;



namespace SWEProject
{
    public partial class Form1 : Form
    {
        CrystalReport6 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport6();
           
            foreach (ParameterDiscreteValue v in CR.ParameterFields[2].DefaultValues)
            {
                comboBox2.Items.Add(v.Value);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(2, comboBox2.Text);
            CR.SetParameterValue(0, startdate.Text);
            CR.SetParameterValue(1, enddate.Text);
            
            crystalReportViewer1.ReportSource = CR;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();

        }
    }
}
