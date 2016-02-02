using System;

namespace ConsoleApplicationExercises
{
    class Coin
    {
        #region constants
        #endregion

        #region fields
        //private decimal _valueOf;
        private Denomination _coinEnumeral;

        #endregion

        #region properties
        public enum Denomination 
        { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }
            
        //  This property will get the monetary value of the coin.    
        public decimal ValueOf
        {
            get { return ((int)_coinEnumeral)/100M; }
        }
            
        //  This property will get the coin name as an enumeral    
        public Denomination CoinEnumeral
        {
            get { return _coinEnumeral; }
            set { _coinEnumeral = value; }
        }

        #endregion

        #region constructors

        // parameterless constructor – coin will be a slug    
        public Coin()    
        {}      
            
        // parametered constructor – coin will be of appropriate value    
        // if value passed is outside normal set (e.g. 5 cents = Nickel)    
        // coin is a slug         
        public Coin(Denomination CoinEnumeral)     
        {
            this.CoinEnumeral = CoinEnumeral;
        }
            
            // This constructor will take a string and return the appropriate enumeral    
        public Coin(string CoinName)          
        {
            this.CoinEnumeral = (Denomination) Enum.Parse(typeof(Denomination), CoinName);
        }
            
            // parametered constructor – coin will be of appropriate value    
            
        public Coin(decimal CoinValue)
        {
            this.CoinEnumeral = (Denomination)(Decimal.ToInt32(CoinValue*100));
        }
        
        #endregion

        #region methods

        public override string ToString()
        {
            return CoinEnumeral.ToString();
        }

        #endregion

    }
}
