using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FarkleDice;

namespace farkle
{
    class AI
    {
        Form1 formtomanip;
        public AI(Form1 myForm)
        {
            formtomanip = myForm;
        }
        public void clickDie(string cStr)
        {
            EventArgs myArgs = new MouseEventArgs(MouseButtons.Left, 1, 10, 10, 0);

            if (cStr == "1")
                formtomanip.die1.dieClicked(null, myArgs);
            else if (cStr == "2")
                formtomanip.die2.dieClicked(null, myArgs);
            else if (cStr == "3")
                formtomanip.die3.dieClicked(null, myArgs);
            else if (cStr == "4")
                formtomanip.die4.dieClicked(null, myArgs);
            else if (cStr == "5")
                formtomanip.die5.dieClicked(null, myArgs);
            else if (cStr == "6")
                formtomanip.die6.dieClicked(null, myArgs);
        }
        public void unclickDie(string cStr)
        {
            EventArgs myArgs = new MouseEventArgs(MouseButtons.Right, 1, 10, 10, 0);

            if (cStr == "1")
                formtomanip.die1.dieClicked(null, myArgs);
            else if (cStr == "2")
                formtomanip.die2.dieClicked(null, myArgs);
            else if (cStr == "3")
                formtomanip.die3.dieClicked(null, myArgs);
            else if (cStr == "4")
                formtomanip.die4.dieClicked(null, myArgs);
            else if (cStr == "5")
                formtomanip.die5.dieClicked(null, myArgs);
            else if (cStr == "6")
                formtomanip.die6.dieClicked(null, myArgs);
        }

    }
}
