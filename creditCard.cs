using System;

namespace Assignment_5
{
    class CreditCard
    {
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
        verify()
        {

        }
         ///<summary>
        /// overrides the base class abstract method. It returns the string “Credit Card” that represents the payment type of this clas
        ///</summary>
        getPaymentType()
        {

        }
    }
}