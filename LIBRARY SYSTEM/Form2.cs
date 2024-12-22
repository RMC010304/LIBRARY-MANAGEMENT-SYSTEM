using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIBRARY_SYSTEM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            rjButton1.BackColor = Color.WhiteSmoke;
            rjButton1.BackgroundImage = Properties.Resources.bookb;
            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();

          
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LMS;User ID=sa;Password=12345678");


        private void GetItems()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=LMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.BOOKS", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
          

        }


        private void GetItems2()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=LMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.BOOKS", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;


        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            
            
            rjButton2.BackColor = Color.RoyalBlue;
            rjButton5.BackColor = Color.RoyalBlue;
            rjButton1.BackColor = Color.WhiteSmoke;
            rjButton3.BackColor = Color.RoyalBlue;
            rjButton4.BackColor = Color.RoyalBlue;

            rjButton4.BackgroundImage = Properties.Resources.star_half__1_;
            rjButton5.BackgroundImage = Properties.Resources.member;
            rjButton1.BackgroundImage = Properties.Resources.bookb;
            rjButton2.BackgroundImage = Properties.Resources.borrow;
            rjButton3.BackgroundImage = Properties.Resources.reserve;
            



            BOOKS.Show();
            MEMBER.Hide();
            BORROW.Hide();
            RESERVATIONS.Hide();
            REVIEWS.Hide();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

            rjButton4.BackgroundImage = Properties.Resources.starb;
            rjButton3.BackgroundImage = Properties.Resources.reserve;
            rjButton2.BackgroundImage = Properties.Resources.borrow;
            rjButton5.BackgroundImage = Properties.Resources.member;
            rjButton1.BackgroundImage = Properties.Resources.book5;


            rjButton2.BackColor = Color.RoyalBlue;
            rjButton5.BackColor = Color.RoyalBlue;
            rjButton1.BackColor = Color.RoyalBlue;
            rjButton3.BackColor = Color.RoyalBlue;
            rjButton4.BackColor = Color.WhiteSmoke;


            

            REVIEWS.Show();
            BOOKS.Hide();
            MEMBER.Hide();
            BORROW.Hide();
            RESERVATIONS.Hide();

            
            
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

            rjButton2.BackColor = Color.RoyalBlue;
            rjButton5.BackColor = Color.WhiteSmoke;
            rjButton1.BackColor = Color.RoyalBlue;
            rjButton3.BackColor = Color.RoyalBlue;
            rjButton4.BackColor = Color.RoyalBlue;

            rjButton4.BackgroundImage = Properties.Resources.star_half__1_;
            rjButton1.BackgroundImage = Properties.Resources.book5;
            rjButton5.BackgroundImage = Properties.Resources.groupb;
            rjButton2.BackgroundImage = Properties.Resources.borrow;
            rjButton3.BackgroundImage = Properties.Resources.reserve;

            MEMBER.Show();
            BOOKS.Hide();
            BORROW.Hide();
            RESERVATIONS.Hide();
            REVIEWS.Hide(); 
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            rjButton4.BackgroundImage = Properties.Resources.star_half__1_;
            rjButton3.BackgroundImage = Properties.Resources.reserve;
            rjButton1.BackgroundImage = Properties.Resources.book5;
            rjButton5.BackgroundImage = Properties.Resources.member;
            rjButton2.BackgroundImage = Properties.Resources.shakeb;

         


            rjButton1.BackColor= Color.RoyalBlue;
            rjButton2.BackColor = Color.WhiteSmoke;
            rjButton5.BackColor = Color.RoyalBlue;
            rjButton3.BackColor = Color.RoyalBlue;
            rjButton4.BackColor = Color.RoyalBlue;

            BORROW.Show();
            BOOKS.Hide();
            MEMBER.Hide() ;
            RESERVATIONS.Hide();
            REVIEWS.Hide();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            rjButton4.BackgroundImage = Properties.Resources.star_half__1_;
            rjButton3.BackgroundImage = Properties.Resources.calendarb;
            rjButton2.BackgroundImage = Properties.Resources.borrow;
            rjButton1.BackgroundImage = Properties.Resources.book5;
            rjButton5.BackgroundImage = Properties.Resources.member;



            rjButton3.BackColor = Color.WhiteSmoke;
            rjButton1.BackColor = Color.RoyalBlue;
            rjButton5.BackColor = Color.RoyalBlue;
            rjButton2.BackColor = Color.RoyalBlue;
            rjButton4.BackColor = Color.RoyalBlue;


            RESERVATIONS.Show();
            BOOKS.Hide() ;
            MEMBER.Hide() ;
            BORROW.Hide() ;
            REVIEWS.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet5.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter2.Fill(this.lMSDataSet5.BOOKS);
            // TODO: This line of code loads data into the 'lMSDataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.lMSDataSet2.BOOKS);
 
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortTimeString();
            label10.Text = DateTime.Now.ToShortDateString();
            label29.Text = DateTime.Now.ToShortTimeString();
            label28.Text = DateTime.Now.ToShortDateString();
            label37.Text = DateTime.Now.ToShortTimeString();
            label36.Text = DateTime.Now.ToShortDateString();
            label39.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rjTextBox3.Texts = string.Empty;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rjTextBox9__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            rjButton11.BackColor = Color.White;
            rjButton9.BackColor = Color.WhiteSmoke;
            rjButton22.BackColor = Color.WhiteSmoke;
            rjButton12.BackColor = Color.WhiteSmoke;

            rjButton10.Show();
            panel5.Show();
            rjButton7.Hide();
            panel4.Hide();
            rjButton23.Hide();
            panel6.Hide();
            rjButton13.Hide();
            panel7.Hide();

            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();


        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            rjButton9.BackColor = Color.White;
            rjButton11.BackColor = Color.WhiteSmoke;
            rjButton22.BackColor = Color.WhiteSmoke;
            rjButton12.BackColor = Color.WhiteSmoke;

            rjButton7.Show();
            panel4.Show();
            rjButton10.Hide();
            panel5.Hide();
            rjButton23.Hide();
            panel6.Hide();
            rjButton13.Hide();
            panel7.Hide();

            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();

        }

        private void rjButton22_Click(object sender, EventArgs e)
        {
            rjButton22.BackColor = Color.White;
            rjButton11.BackColor = Color.WhiteSmoke;
            rjButton9.BackColor = Color.WhiteSmoke;
            rjButton12.BackColor = Color.WhiteSmoke;

            rjButton23.Show();
            panel6.Show();
            rjButton7.Hide();
            panel4.Hide();
            rjButton10.Hide();
            panel5.Hide();
            rjButton13.Hide();
            panel7.Hide();

            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();

        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            rjButton12.BackColor = Color.White;
            rjButton11.BackColor = Color.WhiteSmoke;
            rjButton9.BackColor = Color.WhiteSmoke;
            rjButton22.BackColor = Color.WhiteSmoke;

            rjButton13.Show();
            panel7.Show();
            rjButton7.Hide();
            panel4.Hide();
            rjButton10.Hide();
            panel5.Hide();
            rjButton23.Hide();
            panel6.Hide();

            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();

        }

        private void rjButton37_Click(object sender, EventArgs e)
        {

        }

        private void rjButton16_Click(object sender, EventArgs e)
        {
            panel8.Show();
            rjButton30.Show();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            rjButton30.Hide();
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            panel9.Show();
            rjButton32.Show();
            rjButton30.Hide();
            panel8.Hide();
            rjButton34.Hide();
            panel10.Hide();
            rjButton37.Hide();
            panel11.Hide();

        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel9.Hide(); 
            rjButton32.Hide();
        }

        private void rjButton26_Click(object sender, EventArgs e)
        {
            panel10.Show();
            rjButton34.Show();
            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton37.Hide();
            panel11.Hide();

        }

        private void label17_Click(object sender, EventArgs e)
        {
            panel10.Hide();
            rjButton34.Hide();
        }

        private void rjButton29_Click(object sender, EventArgs e)
        {
            panel11.Show();
            rjButton37.Show();
            rjButton30.Hide();
            panel8.Hide();
            rjButton32.Hide();
            panel9.Hide();
            rjButton34.Hide();
            panel10.Hide();

        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            rjButton37.Hide();
        }

        private void rjButton18_Click(object sender, EventArgs e)
        {

        }

        private void rjButton17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            rjButton30.Hide();

            rjTextBox9.Texts = string.Empty;
            rjTextBox1.Texts = string.Empty;
            rjTextBox4.Texts = string.Empty;
            rjTextBox2.Texts = string.Empty;
            rjTextBox8.Texts = string.Empty;
            rjTextBox5.Texts = string.Empty;
            rjTextBox6.Texts = string.Empty;
            rjTextBox7.Texts = string.Empty;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel10.Hide();
            rjButton34.Hide();

            rjTextBox12.Texts = string.Empty;
            rjTextBox11.Texts = string.Empty;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            panel9.Hide();
            rjButton32.Hide();

            rjTextBox17.Texts = string.Empty;
            rjTextBox16.Texts = string.Empty;
            rjTextBox15.Texts = string.Empty;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            panel11.Hide();
            rjButton37.Hide();

            rjTextBox10.Texts = string.Empty;
            rjTextBox13.Texts = string.Empty;
            rjTextBox14.Texts = string.Empty;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            rjTextBox18.Texts = string.Empty;
        }

        private void rjTextBox25__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
        
        }

        private void label33_Click(object sender, EventArgs e)
        {
       
        }

        private void rjButton42_Click(object sender, EventArgs e)
        {
          
           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            rjTextBox20.Texts = string.Empty;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            rjTextBox21.Texts = string.Empty;
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void rjButton31_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LMS;User ID=sa;Password=12345678");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.BOOKS ([title],[isbn],[publication_year],[edition],[language],[description],[price],[total_copies]) Values (@title,@isbn,@publication_year,@edition,@language,@description,@price,@total_copies)", con);
            cmd.Parameters.AddWithValue("@title", rjTextBox9.Texts);
            cmd.Parameters.AddWithValue("@isbn", rjTextBox1.Texts);
            cmd.Parameters.AddWithValue("@publication_year", rjTextBox2.Texts);
            cmd.Parameters.AddWithValue("@edition", rjTextBox4.Texts);
            cmd.Parameters.AddWithValue("@language", rjTextBox5.Texts);
            cmd.Parameters.AddWithValue("@description", rjTextBox7.Texts);
            cmd.Parameters.AddWithValue("@price", rjTextBox8.Texts);
            cmd.Parameters.AddWithValue("@total_copies", rjTextBox6.Texts);


            cmd.ExecuteNonQuery();
            con.Close();

         

            MessageBox.Show("Added Succesfully!");
            GetItems();
            GetItems2();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
