using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class GameClass
    {
        //ATTRIBUTES

        //deck (holds the playing card deck)
        public Deck myGameDeck = new Deck();

        //Players (holds the players currently playing)
        public PlayerClass myGamePlayer = new PlayerClass();

        //trumpCard
        private PlayingCard myTrumpCard;


        //river (attack/defend cards in the pile)
        public List<PlayingCard> myGameRiver = new List<PlayingCard> { };


        //CONSTRUCTOR
        public GameClass()
        {
            myGameDeck.SetDeck();                       //sets the deck
            myTrumpCard = myGameDeck.GetTrumpCard();    //sets the trump card
                                                        //creates a players hand
            List<PlayingCard> playerHand = new List<PlayingCard> { };

            for(int i=0; i < 6;i++)
            {
                playerHand.Add(myGameDeck.DrawNextCard());
            }
            myGamePlayer.myhand = playerHand;

            //call the main game logic
    }

        //Mutators

        //Remove players
        //public PlayingCard RemovePlayer(PlayingCard removingPlayer)
        //{
        //    //find the value of the player in the list

        //}


        //IsValidCard
        //checks the currently played cards to ensure that the card 
        //that the player selected can be played


        //draw cards which adds the amount of cards needed 
        //to ensure that the player has 6 cards ub there hand



        //main attack logic
        //checks the cards can be played each time a card is placed(IsValidCard)
        //checks who won

        //if the attacker wins(i.e the defender cant play anything)
        //move the river cards into the defenders hand

        //else if the defender wins the round
        //get rid of the cards in the river
        //make the defender the new attacker

    }
}
