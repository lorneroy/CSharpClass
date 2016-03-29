
public delegate string MethodPointer1(string p1);

public class MyMethodPointerDemoClass
{
    public static string StaticMethod(string data)
    {
        return "\n Data from the StaticMethod method: " + data;
    }

    public string InstanceMethod(string data)
    {
        return "\n Data from the InstanceMethod method: " + data;
    }

    public static string LongRunningMethod(string data)
    {
        System.Threading.Thread.Sleep(2000);
        System.Console.Write("\n ++Printing from LongRunningMethod++ \n");
        return "\n Data from the AnotherStaticMethod method: " + data;
    }
}


public class MyEventDelegateDemoClass
{
    //Using the Standard Delegate for Event handling in .NET...
    public event System.EventHandler NonNegitiveNumberUsed;
    public event System.EventHandler NonZeroNumberUsed;

    //You can ignore the Standard Delegate and just making your own...
    public delegate void SimpleEventDelgate(string EventMessage);
    public event SimpleEventDelgate NonPositiveNumberUsed;

    //A better way of doing things is to just extend the Event Arguments class
    private class CustomEventArgs : System.EventArgs
    {
        public string Message;
        public int NumberTried;
        public override string ToString()
        {
            return Message + "," + NumberTried.ToString();
        }
    }


    #region Properties that use the event delegates
    int intNegitiveNumber;
    public int NegitiveNumber
    {
        get { return intNegitiveNumber; }
        set
        {
            if (value < 0)
            {
                intNegitiveNumber = value;
            }
            else
            {
                System.EventArgs objEA = new System.EventArgs();//Note this class is pretty useless in its Raw form.
                NonNegitiveNumberUsed(this, objEA);
            }
        }
    }

    int intPositiveNumber;
    public int PositiveNumber
    {
        get { return intPositiveNumber; }
        set
        {
            if (value > 0)
            {
                intPositiveNumber = value;
            }
            else
            {
                NonPositiveNumberUsed("\n Hey, only use Positive Numbers!");
            }
        }

    }

    int intZeroNumber;
    public int ZeroNumber
    {
        get { return intZeroNumber; }
        set
        {
            if (value == 0)
            {
                intZeroNumber = value;
            }
            else
            {
                CustomEventArgs objCEA = new CustomEventArgs();//Note that our custom Event Args is of more use...
                objCEA.Message = "\n Please don't use a non-Zero number here";
                objCEA.NumberTried = value;
                NonZeroNumberUsed(this, objCEA);
            }
        }
    }
    
    #endregion

}