using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegatesAndEventsDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Simple Delegate Demos
        private void buttonUsingADelegate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n**** Using A Delegate Demo ****\n");
            //Like C++ you can use a delegate to point to a Static method...
            MethodPointer1 objMP_A = new MethodPointer1(MyMethodPointerDemoClass.StaticMethod);
            Console.WriteLine(objMP_A.Invoke("Test1\n"));

            //UN-Like C++ you can also use a delegate to point to a Instance method...
            MyMethodPointerDemoClass objC1 = new MyMethodPointerDemoClass();
            MethodPointer1 objMP_B = new MethodPointer1(objC1.InstanceMethod);
            Console.WriteLine(objMP_B.Invoke("Test2\n"));

            //You can also "Invoke" a delegate by simply using it like a method call...
            Console.WriteLine(objMP_B("Test3\n"));


            //Using a Delegate, really creates an Invisible class with useful Meta-Data. 
            //the new class inherits from the base class called System.MulticastDelegate 
            System.Reflection.MethodInfo objMI = objMP_B.Method;
            Console.WriteLine("\n**** Meta-Data ****\n");
            Console.WriteLine("\tMethod Name: {0} ", objMI.Name);
            Console.WriteLine("\tMethod ReturnType: {0} ", objMI.ReturnType.ToString());
            Console.WriteLine("\tMethod Attributes: {0} ", objMI.Attributes.ToString());
            Console.WriteLine("\tMethod IsConstructor: {0} ", objMI.IsConstructor.ToString());
        }

        private void buttonMulticasting_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n**** Multi Casting with Delegates Demo ****\n");

            MethodPointer1 objMP_D = MyMethodPointerDemoClass.StaticMethod;//Don't use the "+" sign for the first one
            objMP_D += new MyMethodPointerDemoClass().InstanceMethod; //Use the "+" sign to connect additional ones

            // You can fire all methods with one call if the underlining invisible Delegate class 
            // supports it. Since .NET 4.0 delegates inherit from System.MulticastDelegate
            // expect them to multicast.
            Console.WriteLine(objMP_D.Invoke("\nCalling only the last method hooked up!\n"));

            //If not, then you execute non-multicast delegates like this...
            Console.WriteLine("\nUsing a loop to execute all methods\n");
            if (objMP_D != null)
            {
                foreach (MethodPointer1 p in objMP_D.GetInvocationList())
                {
                    Console.WriteLine("\t" + p.Invoke("Now Calling => " + p.Method.Name));
                }
            }
        }
        #endregion

        //------------------------------------------------------//

        #region Asynchronous Demos

        /**************************************************** 
         There are four patterns to call a delegate Asynchronously: 

             *Fire and Forget 
             *Polling 
             *Waiting for Completion 
             *Completion Notification

         ****************************************************/
        MethodPointer1 objMP_Async;

        private void buttonAsyncFireAndForget_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\n**** Using A Async Delegate call with \"Fire and Forget\" ****");
            objMP_Async = MyMethodPointerDemoClass.LongRunningMethod;
            //Note: If your method has parameters, you supply them at the beginning of the argument list.
            //The 2nd to the last argument (AsyncCallback) and last argument (System.Object) follow these,
            //but are not needed here. So, we just put null in their place. 
            objMP_Async.BeginInvoke("Fire and Forget Test", null, null);
            Console.WriteLine("Continuing on Main thread");
            //We don't care about the Async Results since we are demonstrating fire and forget!
        }

        private void buttonAsyncPolling_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\n**** Using A Async Delegate call with \"Polling\" ****");
            objMP_Async = MyMethodPointerDemoClass.LongRunningMethod;
            //Note: The (AsyncCallback) argument and the (System.Object) argument are not used here either.
            IAsyncResult objAR = objMP_Async.BeginInvoke("Polling Test", null, null);

            while (!objAR.IsCompleted)
            {
                Console.WriteLine("Doing other stuff until the other thread finishes");
                System.Threading.Thread.Sleep(1000);
            }

            //Now, continue on...
            Console.WriteLine("Finally! Continuing back on Main thread");
            //Get the Async Results...
            Console.WriteLine("\n\t*Here is the returned data: " + objMP_Async.EndInvoke(objAR));

        }

        private void buttonWaitForCompletion_Click(object sender, EventArgs e)
        {
            //Make an Async call to another thread and wait (But you can timeout if this call takes too long)

            Console.WriteLine("\n**** Using A Async Delegate call with \"Polling\" ****");
            objMP_Async = MyMethodPointerDemoClass.LongRunningMethod;
            //Note: The (AsyncCallback) argument and the (System.Object) argument are not used here  
            IAsyncResult objAR = objMP_Async.BeginInvoke("Some Text", null, null);

            if (!objAR.AsyncWaitHandle.WaitOne(3000)) //Note: You would normally wait longer then 3 seconds!
            {
                Console.WriteLine("\nGive Up! The other Thread took too long");
            }
            else
            {
                //Get the Async Results...
                Console.WriteLine("\n\t*Here is the returned data: " + objMP_Async.EndInvoke(objAR));
            }
            //Continue on...
            Console.WriteLine("Continuing back on Main thread");

        }


        private void buttonCompletionNotification_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\n**** Using A Async Delegate call with \"Completion Notification\" ****");
            objMP_Async = MyMethodPointerDemoClass.LongRunningMethod;
            //Note: This time the (AsyncCallback) argument and the (System.Object) argument ARE Used  
            //EXAMPLE:  BeginInvoke("Parameter Data", 
            //                      (AsyncCallback) = new AsyncCallback(Method to call on completion), 
            //                      (System.Object) = Delegate to describe the original Method being called);
            IAsyncResult objAR = objMP_Async.BeginInvoke("Completion Notification Test"
                                                        , new AsyncCallback(CallBackMethod)
                                                        , objMP_Async);
            Console.WriteLine("Not waiting this time to return to Main thread");
        }

        #region Completion notification support methods
        //When the LongRunningMethod is done, it will return data to this callback method!
        string strStoredDataFromOtherThread = "";
        private void CallBackMethod(IAsyncResult objAR)
        {
            //.Net knows it is safe to CAST the delegate since we passed its type as the 3rd parameter of BeginInvoke()!
            MethodPointer1 objMP = (MethodPointer1)objAR.AsyncState;
            //And, now we can get the returned data by using the EndEnvoke method of the MethodPointer1 delegate
            strStoredDataFromOtherThread = objMP.EndInvoke(objAR);
            Console.WriteLine("\n\tYour data is ready for Pickup");
        }


        private void buttonPickupData_Click(object sender, EventArgs e)
        {
            if (strStoredDataFromOtherThread != "")
            {
                MessageBox.Show(strStoredDataFromOtherThread);
            }
        }
        #endregion //end of CompletionNotification methods

        #endregion

        //------------------------------------------------------//

        #region Delegates and Events
        /*** NOTE: Open and review CodeFile1.cs ***/
        private void buttonDelgatesAndEvents_Click(object sender, EventArgs e)
        {
            MyEventDelegateDemoClass objC2 = new MyEventDelegateDemoClass();
            objC2.NonNegitiveNumberUsed += new EventHandler(objC2_NonNegitiveNumberUsed);
            objC2.NonPositiveNumberUsed += new MyEventDelegateDemoClass.SimpleEventDelgate(objC2_NonPositiveNumberUsed);
            objC2.NonZeroNumberUsed += new EventHandler(objC2_NonZeroNumberUsed);

            Console.WriteLine("\n**Triggering the Non Negative Number Event**");
            objC2.NegitiveNumber = 5;

            Console.WriteLine("\n**Triggering the Non Positive Number Event**");
            objC2.PositiveNumber = -7;

            Console.WriteLine("\n**Triggering the Non Zero Number Event**");
            objC2.ZeroNumber = 9;
        }


        void objC2_NonNegitiveNumberUsed(object sender, EventArgs e)
        {
            Console.WriteLine("\nNot Much info in sender [ {0}  ]  or in e [ {1} ]\n", sender.ToString(), e.ToString());
        }

        void objC2_NonPositiveNumberUsed(string EventMessage)
        {
            Console.WriteLine("\nIgnore Microsoft and use our own delegate w/ a message parameter [ {0} ]\n", EventMessage);
        }

        void objC2_NonZeroNumberUsed(object sender, EventArgs e)
        {
            Console.WriteLine("\nThis is the recommended way to handle Event data [  {0} ]\n", e.ToString());
        }

        #endregion

        //------------------------------------------------------//

        #region Review this first (Creating Generic Parameters, Anonymous Methods, and Lamdas)

        /******** Here are the patterns to look for in this demo... *************/
        //1) The Standard delegate pattern is:
        delegate void DemoDelegate(string P1);

        //2) The pattern of a delegate with a Generic argument is: 
        public delegate void myGenDelegate<T>();//You can define a "Specific" type as its parameter.
        //NOTE:The "T" in <T> can be any set of characters, it is just that "T" indicates any "Type"

        //3) The Anonymous Method - delegate pattern is:
        //  a)The Anonymous Method Methods do not have an name!
        //  b)The Anonymous Method MUST use the delegate syntax!
        //  c)The Anonymous Method delegate must be used within another method!
        //  d)The Anonymous Method can include one or more statements.
        public void AnonymousDummyMethod()
        {  //  d)The method code is included in the method call!
           DemoDelegate delHandle = delegate (string P1) { MessageBox.Show(P1.ToUpper()); }; 
        }

        //4) The Lambda pattern is:
        //  a)Lambda "Methods" do not have an name!
        //  b)Lambda "Methods" DO NOT use the delegate keyword!
        //  c)Lambda "Methods" must be used within another method!
        //  d)Lambda "Methods" can include one or more statements.
        public void LambdaDummyMethod()
        {  //  d)The method code is included in the method call!
           DemoDelegate delHandle = (string P1) => MessageBox.Show(P1.ToUpper()); 
        }
        
        /******** And, here are two classes we will use for this demo... *************/
        class MyCustomEventArgs : EventArgs
        {
            public readonly string EventMessage;
            public MyCustomEventArgs(string EventMessage)
            {
                this.EventMessage = EventMessage;
            }
        }

        class Person
        {
            string strName;
            public event EventHandler<MyCustomEventArgs> NameChanged;

            public string Name
            {
                get { return strName; }
                set { strName = value; if (this.NameChanged != null) this.NameChanged(this, new MyCustomEventArgs("The Name property has changed")); }
            }

        }

           #endregion
        #region Using Anonymous Methods

        /******** Finally, here is the actual demo... *************/
        private void buttonUsingAnnonymousMethods_Click(object sender, EventArgs e)
        {
            //EventHandler is a delegate type, but MyCustomEventArgs is Generic Parameter 
            //use "Go To Definition..." to look at the EventHandler delegate and notice the Generic argument!
            Person objP = new Person();//Example of a Generic(NON-Anonymous) Event-Delegate-Method pattern
            objP.NameChanged += new EventHandler<MyCustomEventArgs>(objP_NameChanged); //Method name
            objP.Name = "Bob Smith";

            //With the Event-Delegate-Anonymous Method pattern you don't name the method, you just supply the code...
            objP.NameChanged += delegate(object Sender, MyCustomEventArgs ev) { MessageBox.Show(ev.EventMessage + ": Delegate"); }; //Method code
            objP.Name = "Bob Smith";

            //With the Event-Lambda Method pattern you don't name the method or the word delegate, you just supply the code...
            objP.NameChanged += (object Sender, MyCustomEventArgs ev) => { MessageBox.Show(ev.EventMessage + ": Lambda"); }; //Method code
            objP.Name = "Bob Smith";

        }

        //This event handler method is NOT Anonymous, since it has a name!
        void objP_NameChanged(object sender, MyCustomEventArgs e)
        {
            MessageBox.Show(e.EventMessage);
        }

        #endregion

    }
}
