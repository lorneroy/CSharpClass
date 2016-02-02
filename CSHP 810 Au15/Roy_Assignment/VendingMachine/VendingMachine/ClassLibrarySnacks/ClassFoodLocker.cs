using System;
using System.Collections.Generic;

namespace ClassLibrarySnacks
{
    public class FoodLocker
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties

        /// <summary>
        /// List of the contents of the food locker
        /// </summary>
        public List<Snack> Store;

        /// <summary>
        /// Number of items that can be placed in the food locker
        /// </summary>
        public int Size;
        #endregion

        #region constructors

        /// <summary>
        /// Constructor for FoodLocker
        /// </summary>
        /// <param name="size">number of items that can be placed in the food locker</param>
        public FoodLocker(int size)
        {
            Size = size;
            Store = new List<Snack>();
        }

        #endregion

        #region methods

        /// <summary>
        /// This method stocks the food locker with a random selection of food
        /// </summary>
        public void Stock()         {
            //clear the contents of the store before stocking
            Store.Clear();
            Random randomNumbers = new Random();
            int number;
            for (int i = 0; i < Size; i++)
            {
                number = randomNumbers.Next(1, 5);
                switch (number)
                {
                    case 1:
                        CandyBar candyBar = new CandyBar("snickers", 1.00M, 200);
                        Store.Add(candyBar);
                        break;
                    case 2:
                        PotatoChips potatoChips = new PotatoChips("lays", 1.25M, 180);
                        Store.Add(potatoChips);
                        break;
                    case 3:
                        Apple apple = new Apple("granny smith apple", 0.50M, DateTime.Now.AddDays(10));
                        Store.Add(apple);
                        break;
                    case 4:
                        Banana banana = new Banana("chiquita banana", 0.50M, DateTime.Now.AddDays(2));
                        Store.Add(banana);
                        break;
                    default:
                        break;
                }
            }        }
        #endregion

    }
}
