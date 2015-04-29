namespace farkle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoundScore = new System.Windows.Forms.Label();
            this.lblPendingScore = new System.Windows.Forms.Label();
            this.btnCashIn = new System.Windows.Forms.Button();
            this.lblRollCount = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.die6 = new FarkleDice.Die();
            this.die5 = new FarkleDice.Die();
            this.die4 = new FarkleDice.Die();
            this.die3 = new FarkleDice.Die();
            this.die2 = new FarkleDice.Die();
            this.die1 = new FarkleDice.Die();
            this.rdoVsPlayer = new System.Windows.Forms.RadioButton();
            this.rdoVsAI = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(45, 13);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(70, 13);
            this.lblP1.TabIndex = 4;
            this.lblP1.Text = "Player1Score";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(233, 13);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(70, 13);
            this.lblP2.TabIndex = 5;
            this.lblP2.Text = "Player2Score";
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Location = new System.Drawing.Point(121, 13);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(13, 13);
            this.lblP1Score.TabIndex = 6;
            this.lblP1Score.Text = "0";
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Location = new System.Drawing.Point(309, 13);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(13, 13);
            this.lblP2Score.TabIndex = 7;
            this.lblP2Score.Text = "0";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(94, 199);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(148, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Location = new System.Drawing.Point(146, 46);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(79, 13);
            this.lblP1Name.TabIndex = 9;
            this.lblP1Name.Text = "Player1 Name: ";
            // 
            // txtP1Name
            // 
            this.txtP1Name.Location = new System.Drawing.Point(231, 43);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(128, 20);
            this.txtP1Name.TabIndex = 10;
            // 
            // txtP2Name
            // 
            this.txtP2Name.Location = new System.Drawing.Point(231, 67);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(128, 20);
            this.txtP2Name.TabIndex = 12;
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Location = new System.Drawing.Point(146, 70);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(79, 13);
            this.lblP2Name.TabIndex = 11;
            this.lblP2Name.Text = "Player2 Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Round Score: ";
            // 
            // lblRoundScore
            // 
            this.lblRoundScore.AutoSize = true;
            this.lblRoundScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRoundScore.Location = new System.Drawing.Point(99, 241);
            this.lblRoundScore.Name = "lblRoundScore";
            this.lblRoundScore.Size = new System.Drawing.Size(0, 13);
            this.lblRoundScore.TabIndex = 17;
            // 
            // lblPendingScore
            // 
            this.lblPendingScore.AutoSize = true;
            this.lblPendingScore.ForeColor = System.Drawing.Color.Teal;
            this.lblPendingScore.Location = new System.Drawing.Point(93, 266);
            this.lblPendingScore.Name = "lblPendingScore";
            this.lblPendingScore.Size = new System.Drawing.Size(0, 13);
            this.lblPendingScore.TabIndex = 18;
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(202, 199);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(75, 23);
            this.btnCashIn.TabIndex = 19;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // lblRollCount
            // 
            this.lblRollCount.AutoSize = true;
            this.lblRollCount.Location = new System.Drawing.Point(20, 282);
            this.lblRollCount.Name = "lblRollCount";
            this.lblRollCount.Size = new System.Drawing.Size(0, 13);
            this.lblRollCount.TabIndex = 20;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(283, 277);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // die6
            // 
            this.die6.BackColor = System.Drawing.Color.White;
            this.die6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die6.Location = new System.Drawing.Point(296, 134);
            this.die6.Name = "die6";
            this.die6.Size = new System.Drawing.Size(48, 48);
            this.die6.TabIndex = 15;
            // 
            // die5
            // 
            this.die5.BackColor = System.Drawing.Color.White;
            this.die5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die5.Location = new System.Drawing.Point(242, 134);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(48, 48);
            this.die5.TabIndex = 14;
            // 
            // die4
            // 
            this.die4.BackColor = System.Drawing.Color.White;
            this.die4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die4.Location = new System.Drawing.Point(188, 134);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(48, 48);
            this.die4.TabIndex = 14;
            // 
            // die3
            // 
            this.die3.BackColor = System.Drawing.Color.White;
            this.die3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die3.Location = new System.Drawing.Point(134, 134);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(48, 48);
            this.die3.TabIndex = 14;
            // 
            // die2
            // 
            this.die2.BackColor = System.Drawing.Color.White;
            this.die2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die2.Location = new System.Drawing.Point(80, 134);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(48, 48);
            this.die2.TabIndex = 14;
            // 
            // die1
            // 
            this.die1.BackColor = System.Drawing.Color.White;
            this.die1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die1.Location = new System.Drawing.Point(26, 134);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(48, 48);
            this.die1.TabIndex = 13;
            // 
            // rdoVsPlayer
            // 
            this.rdoVsPlayer.AutoSize = true;
            this.rdoVsPlayer.Location = new System.Drawing.Point(13, 46);
            this.rdoVsPlayer.Name = "rdoVsPlayer";
            this.rdoVsPlayer.Size = new System.Drawing.Size(103, 17);
            this.rdoVsPlayer.TabIndex = 22;
            this.rdoVsPlayer.TabStop = true;
            this.rdoVsPlayer.Text = "Player vs. Player";
            this.rdoVsPlayer.UseVisualStyleBackColor = true;
            // 
            // rdoVsAI
            // 
            this.rdoVsAI.AutoSize = true;
            this.rdoVsAI.Location = new System.Drawing.Point(13, 79);
            this.rdoVsAI.Name = "rdoVsAI";
            this.rdoVsAI.Size = new System.Drawing.Size(119, 17);
            this.rdoVsAI.TabIndex = 23;
            this.rdoVsAI.TabStop = true;
            this.rdoVsAI.Text = "Player vs. Computer";
            this.rdoVsAI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 307);
            this.Controls.Add(this.rdoVsAI);
            this.Controls.Add(this.rdoVsPlayer);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblRollCount);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.lblPendingScore);
            this.Controls.Add(this.lblRoundScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.die6);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.lblP2Name);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.lblP1Name);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Farkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoundScore;
        private System.Windows.Forms.Label lblPendingScore;
        private System.Windows.Forms.Button btnCashIn;
        private System.Windows.Forms.Label lblRollCount;
        private System.Windows.Forms.Button btnHelp;
        public FarkleDice.Die die1;
        public FarkleDice.Die die2;
        public FarkleDice.Die die3;
        public FarkleDice.Die die4;
        public FarkleDice.Die die5;
        public FarkleDice.Die die6;
        private System.Windows.Forms.RadioButton rdoVsPlayer;
        private System.Windows.Forms.RadioButton rdoVsAI;
    }
}

