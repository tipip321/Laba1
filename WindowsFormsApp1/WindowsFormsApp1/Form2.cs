﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        
        Form2 f2;

        public Form2()
        {
            InitializeComponent();

           

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analiz an = new Analiz();
            an.Visible = true;
            this.Visible = false;


        }
    }
}
