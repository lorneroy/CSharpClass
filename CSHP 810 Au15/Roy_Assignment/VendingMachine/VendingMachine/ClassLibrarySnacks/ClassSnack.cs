using System;

namespace ClassLibrarySnacks
{
    public abstract class Snack
    {
        #region constants
        #endregion

        #region fields
        private string _name;


        private decimal _price;
        #endregion

        #region properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public decimal Price
        {
            get { return _price; }
            set 
            {
                if (value > 0)
                {
                    _price = value;    
                }
            }
        }
        

        #endregion

        #region constructors

        public Snack(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        #endregion

        #region methods

        public override string ToString()
        {
            return String.Format("Snack Food: {0}, {1:C}" + Environment.NewLine, Name, Price);

        }

        #endregion

    }
}
