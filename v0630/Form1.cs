﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vx = -5;
        int vy = -10;
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2; //-ラベルの幅の半分
            label2.Top = fpos.Y - label2.Height / 2;

            label1.Left = label1.Left + vx;
            label1.Top = label1.Top + vy;
           if(label1.Bottom < 0)
            {
                vx=+ 5;
            }
           if(label1.Bottom > ClientSize.Height)
            {
                vy = +-5;
            }
            if(label1.Bottom > ClientSize.Width)
            {
               vy = +10;
            }
            if (label1.Bottom < ClientSize.Height)
            {
                vx = +-10;
            }
            
        }
    }
}
