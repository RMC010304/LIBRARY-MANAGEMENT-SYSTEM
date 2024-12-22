using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LIBRARY_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
           

         Form2 form2 = new Form2();
            this.Hide();
        form2.ShowDialog();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
           

            panel1.BackgroundImage = Properties.Resources.hero;

            MessageBox.Show("You are now in User Mode");
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();

            panel1.BackgroundImage = Properties.Resources.HERO080424C;

            MessageBox.Show("You are now in Admin Mode");

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            User user = new User();

            this.Hide();
            user.ShowDialog();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel5.Hide();
            panel2.Hide();
            panel3.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
           

           
                panel2.Show();
                panel3.Hide();
                panel5.Hide();
                panel4.Hide();

        



            
        }

        private void rjButton5_Click_1(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();
            panel5.Hide();
            panel4.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          
        }
    }
}
