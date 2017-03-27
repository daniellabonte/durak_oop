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

        //River 
        public River myGameRiver = new River();

        //Players (holds the players currently playing)
        public PlayerClass myGamePlayer = new PlayerClass();

        public PlayerClass myAIPlayer = new PlayerClass();

        //trumpCard
        private PlayingCard myTrumpCard;


        //river (attack/defend cards in the pile)
        //public List<PlayingCard> myGameRiver = new List<PlayingCard> { };


        //CONSTRUCTOR
        public GameClass()
        {
            myGameDeck.SetDeck();                       //sets the deck
            myTrumpCard = myGameDeck.GetTrumpCard();    //sets the trump card
            

            //creates a list used to initially set the players hands                                            
            List<PlayingCard> playerHand = new List<PlayingCard> { };
            //TESTING ADDING THE CARDS
            for(int i=0; i < 6;i++)
            {
                playerHand.Add(myGameDeck.DrawNextCard());
            }

            //sets the players hand based on the list created
            myGamePlayer.hand = playerHand;
            //CLEARING THE LIST TO BE USED FOR THE AI PLAYERS HAND

            List<PlayingCard> aiplayerHand = new List<PlayingCard> { };


            for (int i = 0; i < 6; i++)
            {
                aiplayerHand.Add(myGameDeck.DrawNextCard());
            }
            //sets the ai players hand
            myAIPlayer.hand = aiplayerHand;

            //call the main game logic
        }


        //Mutators

        //draw cards which adds the amount of cards needed 
        //to ensure that the player has 6 cards ub there hand


        //checks that the defender can player the card clicked
        //checks that the attacker can play the card clicked


    }
}
