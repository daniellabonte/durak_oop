using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardsLibrary
{
    public class PlayingCard : ICloneable, IComparable
    {
        //Constants
        public const CardSuit MIN_SUIT = (CardSuit)0;
        public const CardSuit MAX_SUIT = (CardSuit)3;
        public const CardRank MIN_RANK = CardRank.Ace;
        public const CardRank MAX_RANK = CardRank.King;

        #region FEILDS AND PROPERTIES

        protected CardSuit mySuit;
        public CardSuit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        protected CardRank myRank;
        public CardRank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        protected bool faceUp = true;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        #endregion

        #region CONSTRUCTORS

        //constructor
        public PlayingCard(CardRank rank = CardRank.Ace, CardSuit suit = CardSuit.hearts)
        {
            //sets rank/suit
            this.myRank = rank;
            this.mySuit = suit;
            //sets the default card
            this.myValue = (int)rank;
        }

        #endregion

        #region PUBLIC METHODS

        public virtual int CompareTo(object obj)
        {
            //is arg null
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object");
            }
            //convert arg to card
            PlayingCard compareCard = obj as PlayingCard;
            //if convertion worked
            if (compareCard != null)
            {
                //compare value first then suit
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else//convertion failed
            {
                throw new ArgumentException("Object being compared cannot be converted to a card");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            string cardString;

            if (faceUp)
            {
                //if rank joker
                if (myRank == CardRank.Joker)
                {
                    //set card name to redblack joker
                    //if suit black
                    if (mySuit == CardSuit.clubs || mySuit == CardSuit.spades)
                    {
                        cardString = "Black Joker";
                    }
                    else
                    {
                        cardString = "Red Joker";
                    }
                }

                else
                {
                    cardString = myRank.ToString() + " of " + mySuit.ToString();

                }
            }
            else
            {
                cardString = "Face Down";
            }
            return cardString;

        }

        public override bool Equals(object obj)
        {
            return (this.CardValue == ((PlayingCard)obj).CardValue);
        }

        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp) ? 1 : 0);
        }

        public Image GetCardImage()
        {
            string imageName;   //name in resourses of img
            Image cardImage;    //holds img

            //if card is not face up
            if (!faceUp)
            {
                //img set to back name
                imageName = "back";
            }
            //checks if it is a joker
            else if (myRank == CardRank.Joker)
            {
                //checks what the suit is and sets the colour acordingly
                if (mySuit == CardSuit.clubs || mySuit == CardSuit.spades)
                {
                    imageName = "black_joker";
                }
                else
                {
                    imageName = "red_joker";
                }
            }
            else
            {
                //otherwise sets the img name based on the suit/rank
                imageName = "_" + (int)myRank + "_of_" + mySuit.ToString();
            }
            //set the img to the approp obj we get from resourse file
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            //return the img
            return cardImage;
        }

        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            cardState += " Value: " + myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;

        }
        #endregion

        #region RELATIONAL OPERATORS
        public static bool operator ==(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue == right.CardValue);
        }
        public static bool operator !=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue != right.CardValue);
        }
        public static bool operator <(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue < right.CardValue);
        }
        public static bool operator >(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue > right.CardValue);
        }
        public static bool operator <=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue <= right.CardValue);
        }
        public static bool operator >=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue >= right.CardValue);
        }


        #endregion
    }
}
