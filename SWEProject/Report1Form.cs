using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEProject
{
    public partial class Report1Form : Form
    {
        CrystalReport1 CR;
        public Report1Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();


        }
    }
}
