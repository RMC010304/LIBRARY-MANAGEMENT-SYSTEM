﻿using System;
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
    public partial class Loading3 : Form
    {
        public Loading3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 4;
            if (panel1.Width > 651)
            {
                timer1.Stop();
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
               
            }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            }
    }
    }
