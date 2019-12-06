using System;

namespace Assignment_5
{
    class Check: Payment
    {
        string bank; 
        string custName; 
        string accNum; 

        /// <summary>
        /// overrides the base class method, it writes to the console the message "Signature and account Balance verified" and returns true; 
        ///</summary>
        verify()
        {

        }

        /// <summary>
        /// :overrides the base class abstract method. It returns the string “Check” that represents the payment type of this class 
        ///</summary>
        public override string getPaymentType()
        {
            return "Check";
        }
    }
}