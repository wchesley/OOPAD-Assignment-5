// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva

using System; 

namespace Assignment_5
{
    abstract class Payment
    {
        public Payment(double Amount, string date)
        {
            amount = Amount;
            paymentDate = date;
        }
        //amount of THIS payment
        static double amount; 
        // date of THIS payment
        static string paymentDate; 

        ///<summary>
        /// returns the payment amount attribute
        ///</summary>
        public static double getAmount()
        {
            return amount; 
        }


        public static string getPaymentDate()
        {
            return paymentDate; 
        }

        ///<summary>
        ///  writes to the console the message “Payment verified“, and returns true. Need to be overloaded by derived classes if needed. 
        ///</summary>
        public virtual bool verify()
        {
            return false; 
        }

        ///<summary>
        /// has no implementation (abstract) in this class, and it need to be implemented in all derived classes. 
        ///</summary>
        public abstract string getPaymentType(); 
    }
}