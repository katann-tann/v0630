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
        int[] vx = new int[1000];
        int[] vy = new int[1000];
        Label[] labels = new Label[1000]; //配置ようの場所
        //静的=最初に決めておく   <> 動的=実行時変更可能
        static Random rand = new Random();
                   //変数名
        public Form1()
        {
            InitializeComponent();

            //★のランダム化
            for (int i = 0; i < 1000; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);


                //★の
                labels[i] = new Label(); //場所に置く箱である
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);
                
                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);


            }
            //for(Label labels[] = 0; labels[] < 3; labels[]++)
            //これではない

        }
        
                   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //マウスの制御
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2; //-ラベルの幅の半分
            label2.Top = fpos.Y - label2.Height / 2;

            //★の制御
            for (int i = 0; i < 1000; i++)
            {
                labels[i].Left = labels[i].Left + vx[i];
                labels[i].Top = labels[i].Top + vy[i];
               


                if (labels[i].Left < 0)

                {
                    vx[i] = Math.Abs(vx[i]);

                }

                if (labels[i].Right > ClientSize.Width)

                {
                    vx[i] = -Math.Abs(vx[i]);

                }
                if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);

                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);

                }
                //当たり判定
                if ((fpos.X >= labels[i].Left)
                  && (fpos.X < labels[i].Right)
                  && (fpos.Y >= labels[i].Top)
                  && (fpos.Y < labels[i].Bottom)
                  )
                {
                    //タイマーストップ
                    labels[i].Visible = false;
                }
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (label3.Left < 0)

            {
                vx[1] = Math.Abs(vx[1]);

            }

            if (label3.Right > ClientSize.Width)

            {
                vx[1] = -Math.Abs(vx[1]);

            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);

            }
            if (label3.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);

            }
            if( (fpos.X >= label3.Left)
              && (fpos.X < label3.Right)
              && (fpos.Y >= label3.Top)
              && (fpos.Y < label3.Bottom)
              )
            {
                //タイマーストップ
                timer1.Enabled = false;
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (label4.Left < 0)

            {
                vx[2] = Math.Abs(vx[2]);

            }

            if (label4.Right > ClientSize.Width)

            {
                vx[2] = -Math.Abs(vx[2]);

            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);

            }
            if (label4.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);

            }
                if( (fpos.X >= label4.Left)
              && (fpos.X < label4.Right)
              && (fpos.Y >= label4.Top)
              && (fpos.Y < label4.Bottom)
              )
            {
                //タイマーストップ
                timer1.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
