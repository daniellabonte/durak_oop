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

            //Check if the Card is a valid card to play depending on the river

                //sets the creates a new card which will be added into the river
                PlayingCard clickedCard = (sender as CardImages.CardImage).Card;
                CardImages.CardImage myCard = new CardImages.CardImage();   //creates the card box
                myCard.Card = clickedCard;//sets the cardboxcard to the card created from the click
                


                //finds the card from the players hand
                PlayingCard cardRemoved = newGame.myGamePlayer.hand.Single(x => x.Rank == clickedCard.Rank && x.Suit == clickedCard.Suit);
                //removes the card from the players hand
                newGame.myGamePlayer.hand.Remove(cardRemoved);
                //adds the card to the river
                newGame.myGameRiver.hand.Add(cardRemoved);
                //updates the players hand
                UpdateHand();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //sets the deck size label
            lblDeckSize.Text = newGame.myGameDeck.deckSize();
            //sets the trump card
            cbTrump.Card = newGame.myGameDeck.GetTrumpCard();
            //updates the cards on the gui
            UpdateHand();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateHand()
        {

            //clears the two flp containers
            flpPlayerHand.Controls.Clear();
            flpAIPlayer.Controls.Clear();
            fplRiver.Controls.Clear();

            //River Cards 
            //updates the rivers cards played
            if (newGame.myGameRiver.hand != null)
            {
                foreach (PlayingCard Card in newGame.myGameRiver.hand)
                {
                    CardImages.CardImage myCard = new CardImages.CardImage();
                    myCard.Card = Card;
                    fplRiver.Controls.Add(myCard);
                }
            }

            
            // player cards
            foreach (PlayingCard Card in newGame.myGamePlayer.hand)
            {
                CardImages.CardImage myCard = new CardImages.CardImage();
                myCard.Card = Card;
                flpPlayerHand.Controls.Add(myCard);
                myCard.CardClicked += new EventHandler(CardClicked);
            }

            //AI Player cards
            foreach (PlayingCard Card in newGame.myAIPlayer.hand)
            {
                CardImages.CardImage myCard = new CardImages.CardImage();
                myCard.Card = Card;
                flpAIPlayer.Controls.Add(myCard);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add the cards from the river to the players hand.
            foreach (PlayingCard Card in newGame.myGameRiver.hand)
            {
                
                newGame.myGamePlayer.hand.Add(Card);
                
            }
            newGame.myGameRiver.hand.Clear();
            UpdateHand();
        }
    }
}
