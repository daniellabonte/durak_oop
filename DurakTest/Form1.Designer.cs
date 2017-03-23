namespace DurakTest
{
    partial class frmDurakGame
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTrump = new System.Windows.Forms.Label();
            this.lblDeckSizelbl = new System.Windows.Forms.Label();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.pnlAIPlayer = new System.Windows.Forms.Panel();
            this.flpPlayerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.fplRiver = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerCard2 = new CardImages.CardImage();
            this.PlayerCard4 = new CardImages.CardImage();
            this.PlayerCard1 = new CardImages.CardImage();
            this.PlayerCard6 = new CardImages.CardImage();
            this.PlayerCard3 = new CardImages.CardImage();
            this.PlayerCard5 = new CardImages.CardImage();
            this.cbTrump = new CardImages.CardImage();
            this.pnlAIPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(874, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTrump
            // 
            this.lblTrump.AutoSize = true;
            this.lblTrump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrump.Location = new System.Drawing.Point(863, 387);
            this.lblTrump.Name = "lblTrump";
            this.lblTrump.Size = new System.Drawing.Size(111, 24);
            this.lblTrump.TabIndex = 15;
            this.lblTrump.Text = "Trump Card";
            // 
            // lblDeckSizelbl
            // 
            this.lblDeckSizelbl.AutoSize = true;
            this.lblDeckSizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSizelbl.Location = new System.Drawing.Point(849, 425);
            this.lblDeckSizelbl.Name = "lblDeckSizelbl";
            this.lblDeckSizelbl.Size = new System.Drawing.Size(99, 24);
            this.lblDeckSizelbl.TabIndex = 16;
            this.lblDeckSizelbl.Text = "Deck Size:";
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.AutoSize = true;
            this.lblDeckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.Location = new System.Drawing.Point(954, 425);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(20, 24);
            this.lblDeckSize.TabIndex = 17;
            this.lblDeckSize.Text = "0";
            // 
            // pnlAIPlayer
            // 
            this.pnlAIPlayer.Controls.Add(this.PlayerCard2);
            this.pnlAIPlayer.Controls.Add(this.PlayerCard4);
            this.pnlAIPlayer.Controls.Add(this.PlayerCard1);
            this.pnlAIPlayer.Controls.Add(this.PlayerCard6);
            this.pnlAIPlayer.Controls.Add(this.PlayerCard3);
            this.pnlAIPlayer.Controls.Add(this.PlayerCard5);
            this.pnlAIPlayer.Location = new System.Drawing.Point(26, 12);
            this.pnlAIPlayer.Name = "pnlAIPlayer";
            this.pnlAIPlayer.Size = new System.Drawing.Size(684, 132);
            this.pnlAIPlayer.TabIndex = 19;
            // 
            // flpPlayerHand
            // 
            this.flpPlayerHand.Location = new System.Drawing.Point(26, 453);
            this.flpPlayerHand.Name = "flpPlayerHand";
            this.flpPlayerHand.Size = new System.Drawing.Size(675, 155);
            this.flpPlayerHand.TabIndex = 20;
            // 
            // fplRiver
            // 
            this.fplRiver.Location = new System.Drawing.Point(26, 227);
            this.fplRiver.Name = "fplRiver";
            this.fplRiver.Size = new System.Drawing.Size(675, 175);
            this.fplRiver.TabIndex = 21;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard2.FaceUp = false;
            this.PlayerCard2.Location = new System.Drawing.Point(122, 14);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard2.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard2.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard2.TabIndex = 1;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard4.FaceUp = false;
            this.PlayerCard4.Location = new System.Drawing.Point(317, 14);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard4.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard4.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard4.TabIndex = 3;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard1.FaceUp = false;
            this.PlayerCard1.Location = new System.Drawing.Point(29, 14);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard1.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard1.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard1.TabIndex = 0;
            // 
            // PlayerCard6
            // 
            this.PlayerCard6.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard6.FaceUp = false;
            this.PlayerCard6.Location = new System.Drawing.Point(517, 14);
            this.PlayerCard6.Name = "PlayerCard6";
            this.PlayerCard6.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard6.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard6.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard6.TabIndex = 5;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard3.FaceUp = false;
            this.PlayerCard3.Location = new System.Drawing.Point(225, 14);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard3.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard3.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard3.TabIndex = 2;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.PlayerCard5.FaceUp = false;
            this.PlayerCard5.Location = new System.Drawing.Point(413, 14);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Rank = CardsLibrary.CardRank.Ace;
            this.PlayerCard5.Size = new System.Drawing.Size(75, 105);
            this.PlayerCard5.Suit = CardsLibrary.CardSuit.hearts;
            this.PlayerCard5.TabIndex = 4;
            // 
            // cbTrump
            // 
            this.cbTrump.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbTrump.FaceUp = false;
            this.cbTrump.Location = new System.Drawing.Point(884, 279);
            this.cbTrump.Name = "cbTrump";
            this.cbTrump.Rank = CardsLibrary.CardRank.Ace;
            this.cbTrump.Size = new System.Drawing.Size(75, 105);
            this.cbTrump.Suit = CardsLibrary.CardSuit.hearts;
            this.cbTrump.TabIndex = 14;
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 620);
            this.Controls.Add(this.fplRiver);
            this.Controls.Add(this.flpPlayerHand);
            this.Controls.Add(this.pnlAIPlayer);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.lblDeckSizelbl);
            this.Controls.Add(this.lblTrump);
            this.Controls.Add(this.cbTrump);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDurakGame";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAIPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CardImages.CardImage PlayerCard1;
        private CardImages.CardImage PlayerCard2;
        private CardImages.CardImage PlayerCard3;
        private CardImages.CardImage PlayerCard4;
        private CardImages.CardImage PlayerCard5;
        private CardImages.CardImage PlayerCard6;
        private System.Windows.Forms.Button btnExit;
        private CardImages.CardImage cbTrump;
        private System.Windows.Forms.Label lblTrump;
        private System.Windows.Forms.Label lblDeckSizelbl;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.Panel pnlAIPlayer;
        private System.Windows.Forms.FlowLayoutPanel flpPlayerHand;
        private System.Windows.Forms.FlowLayoutPanel fplRiver;
    }
}

