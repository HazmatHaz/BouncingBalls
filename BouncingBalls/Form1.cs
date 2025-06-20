﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBalls
{
    public partial class Form1 : Form
    {
        Mover mover;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mover = new Mover(this.Width, this.Height);
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;     
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           mover.Update();
            mover.Display(e.Graphics);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           Invalidate(); //calls the paint event.
        }
    }
}
