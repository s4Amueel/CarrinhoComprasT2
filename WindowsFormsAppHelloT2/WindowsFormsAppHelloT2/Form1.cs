﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHelloT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            
            LblHello.Visible = true;
            if (LblHello.Text=="")
            {
                LblHello.Text = "Hello World!";
                LblHello.ForeColor = Color.Blue;

                pictureBox1.Visible = true;

            }
            
            else
            {
                LblHello.Text = "";
                pictureBox1.Visible= false;
            }

           

            
            
        }

        private void LblHello_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            LblHello.Visible = false;
        }
    }
}
