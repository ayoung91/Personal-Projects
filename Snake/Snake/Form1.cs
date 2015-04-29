using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class frmMain : Form
    {
        int rows, cols;
        float w, h, sqWid, sqHgt;
        int[,] board;
        Random r, c; 
        int seed1, seed2;
        int oldX, oldY;
        
        public frmMain()
        {
            InitializeComponent();
            rows = 10;
            cols = 20;
            oldX = 0;
            oldY = 0;
            board = new int [rows, cols];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int _rows;
            int _cols;
            seed1 = (int)DateTime.Now.Ticks;
            seed2 = (int)DateTime.UtcNow.Ticks;
            r = new Random(seed1);
            c = new Random(seed2);
            
            _rows = r.Next(1, rows);
            _cols = c.Next(1, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols-2; j++)
                { 
                    if(i == _rows && j == _cols)
                    {
                        Graphics g = panel1.CreateGraphics();
                        SolidBrush myNewBrush = new SolidBrush(Color.Red);
                        SolidBrush myOldBrush = new SolidBrush(Color.White);
                        g.FillEllipse(myOldBrush, oldY * sqWid, oldX * sqHgt, sqWid, sqHgt);
                        g.FillEllipse(myNewBrush, j * sqWid, i * sqHgt, sqWid, sqHgt);
                        oldX = i;
                        oldY = j;
                        g.Dispose();
                        myNewBrush.Dispose();
                        myOldBrush.Dispose();

                        break;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            w = panel1.Width;
            h = panel1.Height;

            sqWid = w / cols;
            sqHgt = h / rows;

            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Black);
            for (int i = 0; i < rows; i++)
            {
                //g.DrawLine(myPen, 0, i * sqHgt, cols * sqWid, i * sqHgt);
            }
            for (int i = 0; i < cols; i++)
            {
                //g.DrawLine(myPen, i * sqWid, 0, i * sqWid, cols * sqHgt);
            }
        }
    }
}
