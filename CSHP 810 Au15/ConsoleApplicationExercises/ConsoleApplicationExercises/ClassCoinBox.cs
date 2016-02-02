using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationExercises
{
    class CoinBox
    {
        #region constants
        #endregion

        #region fields
        private List<Coin> box;

        #endregion

        #region properties

        /// <summary>
        /// number of half dollars in the coin box
        /// </summary>
        public int HalfDollarCount 
        {
            get { return countCoins(Coin.Denomination.HALFDOLLAR); }
        }

        /// <summary>
        /// number of quarters in the coin box
        /// </summary>
        public int QuarterCount 
        {
            get { return countCoins(Coin.Denomination.QUARTER); }
        }

        /// <summary>
        /// number of dimes in the coin box
        /// </summary>
        public int DimeCount 
        {
            get { return countCoins(Coin.Denomination.DIME); }
        }
 
        /// <summary>
        /// number of nickels in the coin box
        /// </summary>
        public int NickelCount 
        {
            get { return countCoins(Coin.Denomination.NICKEL); }
        }
 
        /// <summary>
        /// number of worthless coins in the coin box
        /// </summary>
        public int SlugCount 
        {
            get { return countCoins(Coin.Denomination.SLUG); }
        }

        /// <summary>
        /// total amount of money in the coin box 
        /// </summary>
        public decimal ValueOf 
        {
            get
            {
                decimal total=0;
                foreach (Coin _coin in box)
                {
                    total += _coin.ValueOf;
                }
                return total;
            }
        }

        #endregion

        #region constructors

        // constructor to create an empty coin box 
        public CoinBox() 
        {
            box = new List<Coin>();
        }

        // constructor to create a coin box with some coins in it 
        public CoinBox(List<Coin> SeedMoney) 
        {
            box = new List<Coin>(SeedMoney);
        }

        #endregion

        #region methods

        // put a coin in the coin box 
        public void Deposit(Coin ACoin) 
        {
            box.Add(ACoin);
        }

        /// <summary>
        /// take a coin of the specified denomination out of the box
        /// </summary>
        /// <param name="ACoinDenomination"></param>
        /// <returns>true if success</returns>
 
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            return box.Remove(box.First(r => r.CoinEnumeral == ACoinDenomination));
        }

        private int countCoins(Coin.Denomination coinDenomination)
        {
            var coinsOfDenomination = (from coins in box
                                      where coins.CoinEnumeral == coinDenomination
                                      select coins).Count();
            return coinsOfDenomination;
        }


        
        #endregion

    }
}
