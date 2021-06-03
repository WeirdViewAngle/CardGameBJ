using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Card
    {
        #region Fields

        string rank;
        string suit;
        bool faceUp;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a card with the given rank and suit
        /// </summary>
        /// <param name="rank">the rank</param>
        /// <param name="suit">the suit</param>
        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
            faceUp = false;
        }

        #endregion

        #region Properties

        public string Rank 
        {
            get { return rank; }
        }

        public string Suit 
        {
            get { return suit; }
        }

        public bool FaceUp 
        {
            get { return faceUp; }
        }

        #endregion

        #region Public methods

        public void FlipOver() 
        {
            faceUp = !faceUp;
        }

        #endregion
    }
}
