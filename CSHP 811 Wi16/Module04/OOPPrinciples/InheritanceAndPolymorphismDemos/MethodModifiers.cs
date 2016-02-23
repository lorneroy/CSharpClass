using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphismDemos
{

    public class TheBase
    {
        virtual public void DoStuff() { Console.WriteLine("stuff"); }
    }

    public class TheChild1: TheBase
    {
        // Overrides the original method
        override public void DoStuff() { base.DoStuff(); }
    }

    public class TheChild2: TheBase
    {   
        // Shadows the original method
        new public void DoStuff() { base.DoStuff(); }
    }

    public class TheGrandChild: TheChild1
    {
        // To prevent derived types from "overriding" a particular virtual methods
        override sealed public void DoStuff(){}
    }

    public class TheGREATGrandChild: TheGrandChild
    {
        //NOTE: Uncomment this to see the build error!
        //override public void DoStuff(){} 

        //NOTE: Sealed does not prevent shadowing!
        new public void DoStuff(){ }

    }
}
