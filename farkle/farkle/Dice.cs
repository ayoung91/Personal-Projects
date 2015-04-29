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
    class Dice 
    {
        public string sortStr(string dStr)
        {
            char[] output = dStr.ToArray();
            Array.Sort(output);
            return new string(output);
        }
        public bool isSixOfAKind(string dStr)
        {
            try
            { 
                if (dStr.Substring(0, 1) == dStr.Substring(5, 1))
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isTwoThreeOfAKind(string dStr)
        {
            try
            {
                if (dStr.Substring(0, 1) == dStr.Substring(2, 1) &&
                    dStr.Substring(3, 1) == dStr.Substring(5, 1))
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isStraight(string dStr)
        {
            try
            {
                bool success = false;
                for (int i = 0; i < 6; i++)
                {
                    if (Convert.ToInt32(dStr.Substring(i, 1)) == i + 1)
                        success = true;
                    else
                        return false;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreePair(string dStr)
        {
            try
            {
                if (dStr.Substring(0, 1) == dStr.Substring(1, 1) &&
                    dStr.Substring(2, 1) == dStr.Substring(3, 1) &&
                    dStr.Substring(4, 1) == dStr.Substring(5, 1))
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isFourOfAKindWithPair(string dStr)
        {
            try
            {
                if ((dStr.Substring(0, 1) == dStr.Substring(3, 1) &&
                    dStr.Substring(4, 1) == dStr.Substring(5, 1)) ||
                    (dStr.Substring(0, 1) == dStr.Substring(1, 1) &&
                    dStr.Substring(2, 1) == dStr.Substring(5, 1)))
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isFiveOfAKind(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 4; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 3, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 4, 1))
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isFourOfAKind(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 3; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 3, 1))
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeSixes(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "6")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeFives(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "5")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeFours(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "4")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeThrees(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "3")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeTwos(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "2")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public bool isThreeOnes(string dStr)
        {
            bool success = false;
            try
            {
                for (int i = 0; i < dStr.Length - 2; i++)
                {
                    if (dStr.Substring(i, 1) == dStr.Substring(i + 1, 1) &&
                        dStr.Substring(i, 1) == dStr.Substring(i + 2, 1) &&
                        dStr.Substring(i, 1) == "1")
                        success = true;
                }
                if (success)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
        public int numOnes(string dStr)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (dStr.Substring(i, 1) == "1")
                {
                    count++;
                }
            }
            return count; 
        }
        public int numFives(string dStr)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (dStr.Substring(i, 1) == "5")
                {
                    count++;
                }
            }
            return count;
        }
        public string getOddDice(string dStr)
        {
            if (isFiveOfAKind(dStr))
            {
                if (dStr.Substring(0, 1) == dStr.Substring(4, 1))
                    return dStr.Substring(5, 1);
                else
                    return dStr.Substring(0, 1);
            }
            else if (isFourOfAKind(dStr))
            {
                if (dStr.Substring(0, 1) == dStr.Substring(3, 1))
                    return dStr.Substring(4, 1) + dStr.Substring(5, 1); 
                else if (dStr.Substring(1, 1) == dStr.Substring(4, 1))
                    return dStr.Substring(0, 1) + dStr.Substring(5, 1);
                else if (dStr.Substring(2, 1) == dStr.Substring(5, 1))
                    return dStr.Substring(0, 1) + dStr.Substring(1, 1); 
            }
                //Three of a Kind
            else if (dStr.Substring(0, 1) == dStr.Substring(2, 1))
                return dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(1, 1) == dStr.Substring(3, 1))
                return dStr.Substring(0, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(2, 1) == dStr.Substring(4, 1))
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(3, 1) == dStr.Substring(5, 1))
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1); 
                //Odd from Ones
            else if (numOnes(dStr) == 2)
                return dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (numOnes(dStr) == 1)
                return dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
                //Odd from Fives
            else if (dStr.Substring(0, 1) == dStr.Substring(1, 1) && dStr.Substring(1, 1) == "5")
                return dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(1, 1) == dStr.Substring(2, 1) && dStr.Substring(2, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(2, 1) == dStr.Substring(3, 1) && dStr.Substring(3, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(3, 1) == dStr.Substring(4, 1) && dStr.Substring(4, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(4, 1) == dStr.Substring(5, 1) && dStr.Substring(5, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1);
            else if (dStr.Substring(0, 1) == "5")
                return dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(1, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(2, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(3, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(4, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(4, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(5, 1);
            else if (dStr.Substring(5, 1) == "5")
                return dStr.Substring(0, 1) + dStr.Substring(1, 1) + dStr.Substring(2, 1) + dStr.Substring(3, 1) + dStr.Substring(4, 1);

            return "";
        }
        public bool finalFarkleTest(string chosenDice, string oddDice)
        {            
            for (int i = 0; i < chosenDice.Length-1; i++)
            {
                if (chosenDice.Substring(i, 1) == chosenDice.Substring(i + 1, 1))
                {
                    foreach (char ch in oddDice)
                    {
                        if (ch.ToString() == chosenDice.Substring(i, 1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
