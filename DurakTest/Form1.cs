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
        GameClass newGame = new GameClass();
        public frmDurakGame()
        {
            InitializeComponent();
        }
        private void CardClicked(object sender, EventArgs e)
        {
            PlayingCard clickedCard = (sender as CardImages.CardImage).Card;
            CardImages.CardImage myCard = new CardImages.CardImage();
            myCard.Card = clickedCard;
            fplRiver.Controls.Add(myCard);
            //TO-DO: REMOVE THE CARD FROM THE PLAYERS HAND.
            
            UpdateHand();
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

            

            lblDeckSize.Text = newGame.myGameDeck.deckSize();

            cbTrump.Card = newGame.myGameDeck.GetTrumpCard();

            UpdateHand();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateHand()
        {
            flpPlayerHand.Controls.Clear();//TO-DO:NEEDS TO CLEAR THE FLPPLAYERHAND
            // player cards
            foreach (PlayingCard Card in newGame.myGamePlayer.myhand)
            {
                
                CardImages.CardImage myCard = new CardImages.CardImage();
                myCard.Card = Card;
                flpPlayerHand.Controls.Add(myCard);
                myCard.CardClicked += new EventHandler(CardClicked);
            }

        }
        
    }
}
