using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_SYSTEM
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();



            panel12.Hide();
            rjButton45.Hide();

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet3.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.lMSDataSet3.BOOKS);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortTimeString();
            label10.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rjTextBox3.Texts = string.Empty;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjButton9.BackColor = Color.WhiteSmoke;
            rjButton1.BackColor = Color.White;


            rjButton42.Show();
            rjButton7.Show();
            panel2.Show();

            panel3.Hide();
            rjButton2.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rjButton42_Click(object sender, EventArgs e)
        {
            panel12.Show();
            rjButton45.Show();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            rjButton45.Hide();

            rjTextBox22.Texts = string.Empty;
            rjTextBox19.Texts = string.Empty;
            rjTextBox25.Texts = string.Empty;
            rjTextBox23.Texts = string.Empty;
            rjTextBox24.Texts = string.Empty;
            rjTextBox26.Texts = string.Empty;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            rjButton45.Hide();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            rjButton1.BackColor = Color.WhiteSmoke;
            rjButton9.BackColor = Color.White;

            panel3.Show();
            rjButton2.Show();

            rjButton42.Hide();
            rjButton7.Hide();
            panel2.Hide();

            
        }
    }
}
