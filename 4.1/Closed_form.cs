﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1
{

    public partial class Closed_form : Form
    {
        public bool chenge { get; set; } = false;
        public Closed_form(bool Myenum)
        {
            InitializeComponent();
            if (Myenum)
            {
                this.label1.Text = "Сохранить старые данные?";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chenge = true;
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}
