using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardsLibrary;

namespace CardImages
{
    public partial class CardImage: UserControl
    {



        #region PROPS AND FIELDS
        private PlayingCard myCard;
        public PlayingCard Card
        {
            set
            {
                myCard = value;
                UpdateCardImage();
            }
            get { return myCard; }

        }
        public CardSuit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }
            get { return Card.Suit; }
        }

        public CardRank Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage();
            }
            get { return Card.Rank; }
        }

        public bool FaceUp
        {
            set
            {
                //checks if val is diff
                if (myCard.FaceUp != value)
                {
                    myCard.FaceUp = value;

                    UpdateCardImage();
                    //if there is an event handler
                    if (CardFlipped != null)
                    {
                        CardFlipped(this, new EventArgs()); //call it
                    }
                }
            }
            get { return Card.FaceUp; }
        }

        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                // if value is different then my orientation
                if (myOrientation != value)
                {
                    myOrientation = value; // change the orientation
                    // swap the height and width of the control 
                    this.Size = new Size(Size.Height, Size.Width);
                    // update the card image.
                    UpdateCardImage();
                }
            }
            get { return myOrientation; }
        }


        public void UpdateCardImage()
        {
            //SETS IMG  
            pictureBox1.Image = myCard.GetCardImage();

            //if orientation is horizontal
            if (myOrientation == Orientation.Horizontal)
            {
                //rotate img
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        #endregion


        //new card oriented vertically
        public CardImage()
        {
            InitializeComponent();  //required for method design support
            myOrientation = Orientation.Vertical;   //set to vertical
            myCard = new PlayingCard(); //create underlying card

        }
        //param constructor
        public CardImage(PlayingCard Card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();  //required for method design support
            myOrientation = orientation;   //set to vertical
            myCard = Card;
        }

        #region Events /Event handlers

        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        //dele that event is linked to
        new public event EventHandler CardClicked;
        public event EventHandler CardFlipped;

        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            OnCardClicked(EventArgs.Empty); // Raise card clicked event
        }

        #endregion

        #region other Methods
        //returns playing card as string
        public override string ToString()
        {
            return myCard.ToString();
        }

        protected virtual void OnCardClicked(EventArgs e)
        {
            if (CardClicked != null)
                CardClicked(this, e);
        }

        #endregion


    }
}
