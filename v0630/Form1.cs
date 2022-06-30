using System;
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
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);
        int point = 100;
        //静的=最初に決めておく <> 動的=実行時変更可能
        static Random rand = new Random();
                   //変数名
        public Form1()
        {
            InitializeComponent();

           
            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height); 
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);

        }
        
                   

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

            label1.Left = label1.Left + vx1;
            label1.Top = label1.Top + vy1;
            label3.Top = label3.Top+ vy2 ;
            label3.Left = label3.Left+vx2;
            label4.Top = label4.Top + vy3;
            label4.Left = label4.Left + vx3;

            if (label1.Left < 0)
              
            {
                vx1 = Math.Abs(vx1); 
               
            }
            if (label1.Right > ClientSize.Width)
            
            {
                vx1 = -Math.Abs(vx1);
              
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy1);
              
            }
            if (label1.Top < 0)
            {
                vy1 = Math.Abs(vy1);
               
            }
            if((fpos.X >=label1.Left)
              && (fpos.X<label1.Right )
              && (fpos.Y>=label1.Top)
              && (fpos.Y<label1.Bottom)
              )
            {
                timer1.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
