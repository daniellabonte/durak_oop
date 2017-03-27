using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class PlayerClass
    {

        //player hand
        private List<PlayingCard> myhand = new List<PlayingCard> { };
        public List<PlayingCard> hand
        {
            get
            {
                return myhand;
            }
            set
            {
                myhand = value;
            }
        }
        //hand size
        private int myhandSize;

        //mutators

        public int handSize
        {
            get
            {
                return myhandSize;
            }
            set
            {
                //TODO: VALIDATION!!!!!!!!!!!!¯\_ಠ_ಠ_/¯
                myhandSize = value;
            }
        }

        //TO-DO: ADD VALIDATION TO THE ADDING CARDS TO YOUR HAND

        public PlayerClass(List<PlayingCard> hand)
        {
            myhand = hand;
            handSize = hand.Count();
        }
        public PlayerClass()
        {
            myhand = new List<PlayingCard>();
            handSize = 0;
        }



    }
}
