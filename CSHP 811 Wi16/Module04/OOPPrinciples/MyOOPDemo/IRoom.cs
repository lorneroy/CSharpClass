using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPDemo
{
    public interface IRoom
    {
        float Width
        {
            get;
            set;
        }

        float Size
        {
            get;
            set;
        }

        string Number
        {
            get;
            set;
        }

        int Outlets
        {
            get;
            set;
        }


        string GetData();
    }
}
