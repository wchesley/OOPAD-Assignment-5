// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva

using System;

namespace Assignment_5
{
    class CreditCard: Payment
    {
        public CreditCard(double amount, string ccnum, string cctype, string expdate, string ccholdername, string purchaseDate): base (amount, purchaseDate)
        {
            CCNum = ccnum;
            expDate = expdate;
            CHOlderName = ccholdername;
            CType = cctype; 
        }
        // credit card number 
        string CCNum;  
        // expiration date 
        string expDate; 
        // card holder name
        string CHOlderName; 
        //visa, mastercard, american express, ect... 
        string CType; 

        ///<summary>
        ///overrides the base class method, it writes to the console the message "Credit card verified" and returns true;
        ///</summary>
        public override bool verify()
        {
            Console.WriteLine("Credit card verified");
            return true; 
        }
         ///<summary>
        /// overrides the base class abstract method. It returns the string “Credit Card” that represents the payment type of this clas
        ///</summary>
        public override string getPaymentType()
        {
            return "Credit Card";
        }
    }
}