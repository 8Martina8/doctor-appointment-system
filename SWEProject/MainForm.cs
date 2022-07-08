
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SignIn s = new SignIn();
            s.Show();
            this.Hide(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report1Form f = new Report1Form();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateAccount c = new CreateAccount();
            c.Show();
            this.Hide();
        }
    }
}
