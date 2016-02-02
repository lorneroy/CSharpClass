/*
 * Name: Lorne Roy
 * Student ID: 0034514 
 */

using System;

namespace ConsoleApplicationExercises
{
    /// <summary>
    ///  This class represents the purchase price of something. 
    ///  In our software project, we will use it to represent the price of one can of soda.
    /// </summary>
    class PurchasePrice
    {
        #region constants
        #endregion

        #region fields

        private decimal _price;

        #endregion

        #region properties

        // This property gets and sets the value the purchase price.
        public int Price
        {
            get { return Convert.ToInt32(_price * 100); }
            private set
            {
                if (value >= 0)
                {
                    _price = Convert.ToDecimal(value / 100.0);
                }
                else
                {
                    value = 0;
                }

            }
        }
        
        public decimal PriceDecimal
        {
            get { return _price; }
            private set { _price = value; }
        }
        #endregion

        #region constructors

        // This constructor sets the purchase price to zero
        public PurchasePrice() : this(0) { }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        #endregion

        #region methods
        #endregion
        
    }

}//end PurchasePrice
