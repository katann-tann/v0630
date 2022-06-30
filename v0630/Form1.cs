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
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);
        int point = 100;
        //静的=最初に決めておく <> 動的=実行時変更可能
        static Random rand = new Random();
        //変数名
        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(0, ClientSize.Width);
            label1.Top = rand.Next(0, ClientSize.Height);

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

            label1.Left = label1.Left + vx;
            label1.Top = label1.Top + vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx); 
               
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
              
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
              
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
               
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
    }
}
