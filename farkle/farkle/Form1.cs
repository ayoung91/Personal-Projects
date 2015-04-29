using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarkleDice;

namespace farkle
{
    public partial class Form1 : Form
    {
        Form1 frm;
        string p1Name, p2Name, dStr;
        int rollCount;
        int p1Score, tempScore, p2Score, pendingScore;
        int turn;
        string oddDice, chosenDice;
        bool isFarkle, found, isAI, isHuman;
        Dice d = new Dice();

        public Form1()
        {
            InitializeComponent();
            rollCount = 1;
            dStr = "";
            oddDice = "";
            chosenDice = "";
            p1Score = 0;
            p2Score = 0;
            tempScore = 0;
            pendingScore = 0;
            turn = 1;
            isFarkle = true;
            found = false;
            lblP1.Visible = false;
            lblP1Score.Visible = false;
            lblP2.Visible = false;
            lblP2Score.Visible = false;
            lblRollCount.Visible = false;
            label1.Visible = false;
            btnRoll.Visible = false;
            btnCashIn.Visible = false;
            die1.Visible = false;
            die2.Visible = false;
            die3.Visible = false;
            die4.Visible = false;
            die5.Visible = false;
            die6.Visible = false;
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            rollCount++;
            evaluate();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            p1Name = txtP1Name.Text;
            p2Name = txtP2Name.Text;

            if (p1Name == "")
                p1Name = "Player 1";
            if (p2Name == "")
                p2Name = "Player 2";
            lblP1.Text = p1Name + " Score:";
            lblP2.Text = p2Name + " Score:";
            if (rdoVsAI.Checked)
            { 
                isAI = true;
                isHuman = false;
            }
            if (rdoVsPlayer.Checked)
            {
                isHuman = true;
                isAI = false;
            }

            btnStart.Visible = false;
            lblP1.Visible = true;
            lblP1Score.Visible = true;
            lblP2.Visible = true;
            lblP2Score.Visible = true;
            lblP1Name.Visible = false;
            lblP2Name.Visible = false;
            lblRollCount.Visible = true;
            label1.Visible = true;
            txtP1Name.Visible = false;
            txtP2Name.Visible = false;
            btnRoll.Visible = true;
            btnCashIn.Visible = true;
            rdoVsAI.Visible = false;
            rdoVsPlayer.Visible = false;
            die1.Visible = true;
            die2.Visible = true;
            die3.Visible = true;
            die4.Visible = true;
            die5.Visible = true;
            die6.Visible = true;
            evaluate();
        }
        public void reset(string dStr)
        {
            dStr = "";
            die1.resetDice();
            die2.resetDice();
            die3.resetDice();
            die4.resetDice();
            die5.resetDice();
            die6.resetDice();
            rollCount = 1;
            pause();
            getDice();
            pendingScore = 0;
            lblPendingScore.Text = "";
        }
        private void btnCashIn_Click(object sender, EventArgs e)
        {
            cashIn();
        }
        public void evaluate()
        {
            changePlayerColor();
            if (isHuman)
                playHuman();
            if (isAI)
                playAI();
        }
        public void playHuman()
        {
            if (rollCount <= 3)
            {
                lblRollCount.Text = "Roll Count: " + rollCount.ToString();

                getDice();

                isFarkle = true;
                pendingScore = 0;
                lblPendingScore.Text = "";
                lblRoundScore.ForeColor = Color.Green;
                lblRoundScore.Text = tempScore.ToString();

                checkFarkle();
                getBestHand();
            }
            if (rollCount == 3 && !isFarkle) //Maximized roll count. Cash in points and change players
            {
                lastRoll();
            }
        }
        public void playAI()
        {
            
        }
        public void changePlayerColor()
        {
            if (turn == 1)
            {
                lblP1.ForeColor = Color.Blue;
                lblP2.ForeColor = Color.Black;
            }
            else
            {
                lblP2.ForeColor = Color.Blue;
                lblP1.ForeColor = Color.Black;
            }
        }
        public void FarkleTrue()
        {
            tempScore = 0;
            pendingScore = 0;
            lblPendingScore.Text = "";

            rollCount = 1;
            lblRollCount.Text = "Roll Count: " + rollCount;
            reset(dStr);

            if (turn == 1)
                turn = 2;
            else
                turn = 1;

            getBestHand();
            lblRoundScore.Text = "Farkle!";
            lblRoundScore.ForeColor = Color.Red;
            checkFarkle();
        }
        public void getDice()
        {
            dStr = "";
            oddDice = "";
            chosenDice = "";
            dStr += die1.newDraw().ToString();
            dStr += die2.newDraw().ToString();
            dStr += die3.newDraw().ToString();
            dStr += die4.newDraw().ToString();
            dStr += die5.newDraw().ToString();
            dStr += die6.newDraw().ToString();
            if (rollCount == 1)
                oddDice = dStr;
            else
            {
                oddDice += die1.oddDice(oddDice);
                oddDice += die2.oddDice(oddDice);
                oddDice += die3.oddDice(oddDice);
                oddDice += die4.oddDice(oddDice);
                oddDice += die5.oddDice(oddDice);
                oddDice += die6.oddDice(oddDice);
                chosenDice += die1.chosenDice(chosenDice);
                chosenDice += die2.chosenDice(chosenDice);
                chosenDice += die3.chosenDice(chosenDice);
                chosenDice += die4.chosenDice(chosenDice);
                chosenDice += die5.chosenDice(chosenDice);
                chosenDice += die6.chosenDice(chosenDice);
            }

            dStr = d.sortStr(dStr);
            oddDice = d.sortStr(oddDice);
            chosenDice = d.sortStr(chosenDice);
        }
        public void checkFarkle()
        {
            if (oddDice == "")
                isFarkle = false;
            else
            {
                foreach (char ch in oddDice)
                {
                    if (ch == '1' || ch == '5')
                    {
                        isFarkle = false;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    if (!d.isSixOfAKind(dStr) && !d.isTwoThreeOfAKind(dStr) &&
                        !d.isStraight(dStr) && !d.isThreePair(dStr) && !d.isFourOfAKindWithPair(dStr) &&
                        !d.isFiveOfAKind(oddDice) && !d.isFourOfAKind(oddDice) && !d.isThreeSixes(oddDice) &&
                        !d.isThreeFives(oddDice) && !d.isThreeFours(oddDice) && !d.isThreeThrees(oddDice) &&
                        !d.isThreeTwos(oddDice) && !d.isThreeOnes(oddDice) && !d.finalFarkleTest(chosenDice, oddDice))
                        isFarkle = true;
                    else
                        isFarkle = false;
                }
                if (isFarkle)
                {
                    FarkleTrue();
                }
                found = false;
            }
        }
        public void getBestHand()
        {
            if (d.isSixOfAKind(dStr))
            {
                tempScore += 3000;
                lblRoundScore.Text = tempScore.ToString();
                reroll();
                runningTotalBugFix();
            }
            else if (d.isTwoThreeOfAKind(dStr))
            {
                tempScore += 2500;
                lblRoundScore.Text = tempScore.ToString();
                reroll();
                runningTotalBugFix();
            }
            else if (d.isStraight(dStr))
            {
                tempScore += 1500;
                lblRoundScore.Text = tempScore.ToString();
                reroll();
                runningTotalBugFix();
            }
            else if (d.isThreePair(dStr))
            {
                tempScore += 1500;
                lblRoundScore.Text = tempScore.ToString();
                reroll();
                runningTotalBugFix();
            }
            else if (d.isFourOfAKindWithPair(dStr))
            {
                tempScore += 1500;
                lblRoundScore.Text = tempScore.ToString();
                reroll();
                runningTotalBugFix();
            }
            else if (d.isFiveOfAKind(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 2000;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if (d.getOddDice(dStr) == "1")
                {
                    tempScore += 2100;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
                else if (d.getOddDice(dStr) == "5")
                {
                    tempScore += 2050;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isFourOfAKind(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 1000;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if (d.getOddDice(dStr).Substring(0, 1) == "1" && d.getOddDice(dStr).Substring(1, 1) == "5" ||
                    d.getOddDice(dStr).Substring(0, 1) == "5" && d.getOddDice(dStr).Substring(1, 1) == "1")
                {
                    tempScore += 1150;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isThreeSixes(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 600;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "1" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 850;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
                else if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "5" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 800;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isThreeFives(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 500;
                lblPendingScore.Text = "+" + pendingScore.ToString();
            }
            else if (d.isThreeFours(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 400;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "1" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 650;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
                else if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "5" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 600;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isThreeThrees(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 300;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "1" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 550;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
                else if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "5" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 500;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isThreeTwos(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 200;
                lblPendingScore.Text = "+" + pendingScore.ToString();
                if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "1" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 450;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
                else if ((d.getOddDice(dStr).Substring(0, 1) == "1" &&
                    d.getOddDice(dStr).Substring(1, 1) == "5" &&
                    d.getOddDice(dStr).Substring(2, 1) == "5"))
                {
                    tempScore += 400;
                    lblRoundScore.Text = tempScore.ToString();
                    reroll();
                    runningTotalBugFix();
                }
            }
            else if (d.isThreeOnes(dStr))
            {
                lblRoundScore.Text = tempScore.ToString();
                pendingScore = 300;
                lblPendingScore.Text = "+" + pendingScore.ToString();
            }

            int countOnes = d.numOnes(dStr);
            if (countOnes < 3 && countOnes > 0 && !isFarkle)
            {
                pendingScore += 100 * countOnes;
                lblPendingScore.Text = "+" + pendingScore.ToString();
            }
            countOnes = 0;
            int countFives = d.numFives(dStr);
            if (countFives < 3 && countFives > 0 && !isFarkle)
            {
                pendingScore += 50 * countFives;
                lblPendingScore.Text = "+" + pendingScore.ToString();
            }
            countFives = 0;
            ifWinner();
        }
        public void lastRoll()
        {
            pause();
            if (turn == 1)
            {
                p1Score += tempScore + pendingScore;
                lblP1Score.Text = p1Score.ToString();
                turn = 2;
            }
            else if (turn == 2)
            {
                p2Score += tempScore + pendingScore;
                lblP2Score.Text = p2Score.ToString();
                turn = 1;
                
            }
            reset(dStr);
            changePlayerColor();
            lblRollCount.Text = "Roll Count: " + rollCount;
            tempScore = 0;
            lblRoundScore.Text = tempScore.ToString();
            getBestHand();
            checkFarkle();
            ifWinner();
        }
        public void pause()
        {
            System.Threading.Thread.Sleep(2000);
        }
        public void reroll()
        {
            reset(dStr);
            checkFarkle();
            pendingScore = 0;
            getBestHand();
            ifWinner();
        }
        public void ifWinner()
        {
            if (p1Score >= 10000 || p2Score >= 10000)
            { 
                if (p1Score >= 10000)
                    MessageBox.Show(p1Name + " Wins!");
                else
                    MessageBox.Show(p2Name + " Wins!");
                p1Score = 0;
                lblP1Score.Text = p1Score.ToString();
                p2Score = 0;
                lblP2Score.Text = p2Score.ToString();
                oddDice = "";
                p1Score = 0;
                p2Score = 0;
                tempScore = 0;
                turn = 1;
                isFarkle = true;
                found = false;
                reset(dStr);
                evaluate();
            }
        }
        public void runningTotalBugFix()
        {
            foreach(char ch in dStr)
            {
                if (ch == '1')
                    pendingScore -= 100;
                else if (ch == '5')
                    pendingScore -= 50;
            }
        }
        public void cashIn()
        {
            if (turn == 1)
            {
                p1Score += tempScore + pendingScore;
                lblP1Score.Text = p1Score.ToString();
                reset(dStr);
                turn = 2;
            }
            else if (turn == 2)
            {
                p2Score += tempScore + pendingScore;
                lblP2Score.Text = p2Score.ToString();
                reset(dStr);
                turn = 1;
            }
            lblRoundScore.Text = "";
            rollCount = 1;
            tempScore = 0;
            getBestHand();
            checkFarkle();
            changePlayerColor();
            ifWinner();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.Show();
        }
    }
}
