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
            this.flpPlayerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.fplRiver = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAIPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPlayerState = new System.Windows.Forms.Label();
            this.cbTrump = new CardImages.CardImage();
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
            // flpAIPlayer
            // 
            this.flpAIPlayer.Location = new System.Drawing.Point(26, 12);
            this.flpAIPlayer.Name = "flpAIPlayer";
            this.flpAIPlayer.Size = new System.Drawing.Size(675, 175);
            this.flpAIPlayer.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Defeat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPlayerState
            // 
            this.lblPlayerState.AutoSize = true;
            this.lblPlayerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlayerState.Location = new System.Drawing.Point(21, 424);
            this.lblPlayerState.Name = "lblPlayerState";
            this.lblPlayerState.Size = new System.Drawing.Size(110, 25);
            this.lblPlayerState.TabIndex = 24;
            this.lblPlayerState.Text = "Defending";
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
            this.Controls.Add(this.lblPlayerState);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpAIPlayer);
            this.Controls.Add(this.fplRiver);
            this.Controls.Add(this.flpPlayerHand);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.lblDeckSizelbl);
            this.Controls.Add(this.lblTrump);
            this.Controls.Add(this.cbTrump);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDurakGame";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private CardImages.CardImage cbTrump;
        private System.Windows.Forms.Label lblTrump;
        private System.Windows.Forms.Label lblDeckSizelbl;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.FlowLayoutPanel flpPlayerHand;
        private System.Windows.Forms.FlowLayoutPanel fplRiver;
        private System.Windows.Forms.FlowLayoutPanel flpAIPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPlayerState;
    }
}

