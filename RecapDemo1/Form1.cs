﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            button.Text = "Benim Butonum";
            this.Controls.Add(button);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
