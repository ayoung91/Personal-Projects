using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace FarkleDice
{ 
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class Die: UserControl
    {
        private static readonly Random rand = new Random();
        private static readonly object syncLock = new object();
        private int intRand, keptDice;
        bool enable;
        public Die()
        {
            InitializeComponent();
            intRand = 0;
            enable = true;
        }

        private void Die_Click(object sender, EventArgs e)
        {
            dieClicked(sender, e);
        }
        public void dieClicked(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                Pen myPen = new Pen(Color.Red);
                myPen.Width = 3;
                g.DrawRectangle(myPen, 0, 0, 50, 50);
                enable = false;
                this.newDraw();
            }
            else if (me.Button == MouseButtons.Right)
            {
                Pen myPen = new Pen(Color.White);
                myPen.Width = 3;
                g.DrawRectangle(myPen, 0, 0, 50, 50);
                enable = true;
            }
        }
        public void redrawDice(int d)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);

            if (enable == false)
            {
                switch (d)
                {
                    case 1:
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        break;
                    case 2:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                    case 3:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                    case 4:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                    case 5:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        break;
                    case 6:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 20, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 20, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                }
            }
        }
        public int newDraw()
        {
            Graphics g = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            
            g.Clear(Color.White);

            if(enable == true)
            {
                lock (syncLock)
                    intRand = rand.Next(1, 7);

                switch (intRand)
                {
                    case 1:
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        break;
                    case 2:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                    case 3:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        g.FillEllipse(myBrush, 30,30, 8, 8);
                        break;
                    case 4:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                    case 5:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        g.FillEllipse(myBrush, 20, 20, 8, 8);
                        break;
                    case 6:
                        g.FillEllipse(myBrush, 10, 10, 8, 8);
                        g.FillEllipse(myBrush, 10, 20, 8, 8);
                        g.FillEllipse(myBrush, 10, 30, 8, 8);
                        g.FillEllipse(myBrush, 30, 10, 8, 8);
                        g.FillEllipse(myBrush, 30, 20, 8, 8);
                        g.FillEllipse(myBrush, 30, 30, 8, 8);
                        break;
                }
            }
            else
            {
                keptDice = intRand;
                redrawDice(keptDice);
            }
            return intRand;
        }
        public void resetDice()
        {
            enable = true;
        }
        public string oddDice(string current)
        {
            if (enable == true)
                return intRand.ToString();
            else
                return "";
        }
        public string chosenDice(string current)
        {
            if (enable != true)
                return intRand.ToString();
            else
                return "";
        }
    }
}
