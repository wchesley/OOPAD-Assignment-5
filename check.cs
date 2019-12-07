// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva

using System;

namespace Assignment_5
{
    class Check: Payment
    {
        public Check(double Amount, string bankName, string checkHolderName, string custAcc, string purchaseDate): base (Amount, purchaseDate)
        {
            bank = bankName;
            custName = checkHolderName;
            accNum = custAcc;
        }
        string bank; 
        string custName; 
        string accNum; 

        /// <summary>
        /// overrides the base class method, it writes to the console the message "Signature and account Balance verified" and returns true; 
        ///</summary>
        public override bool verify()
        {
            Console.WriteLine("Check");
            return true; 
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