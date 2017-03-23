using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardsLibrary;

namespace DurakTest
{
    public partial class frmDurakGame : Form
    {
        public frmDurakGame()
        {
            InitializeComponent();
        }
        private void CardClicked(object sender, EventArgs e)
        {
            lblDeckSize.Text = "clicked";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            PlayingCard theCard = new CardsLibrary.PlayingCard(CardRank.Joker, CardSuit.clubs);
            this.PlayerCard1.Card = theCard;
            this.PlayerCard2.Card = theCard;
            this.PlayerCard3.Card = theCard;
            this.PlayerCard4.Card = theCard;
            this.PlayerCard5.Card = theCard;
            this.PlayerCard6.Card = theCard;

            GameClass newGame = new GameClass();

            lblDeckSize.Text = newGame.myGameDeck.deckSize();

            cbTrump.Card = newGame.myGameDeck.GetTrumpCard();

            foreach (PlayingCard Card in newGame.myGamePlayer.myhand)
            {
                CardImages.CardImage myCard = new CardImages.CardImage();
                myCard.Card = Card;
                flpPlayerHand.Controls.Add(myCard);
                myCard.CardClicked += new EventHandler(CardClicked);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateHand()
        {
            // player cards
            
            
        }
        
    }
}
