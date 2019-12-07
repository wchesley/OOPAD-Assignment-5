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
            amounts = Amount;
            paymentDates = date;
        }
        //amount of THIS payment
        public double amounts; 
        
        // date of THIS payment
        public string paymentDates; 

        ///<summary>
        /// returns the payment amount attribute
        ///</summary>
        public double getAmount()
        {
            return amounts; 
        }


        public string getPaymentDate()
        {
            return paymentDates; 
        }

        ///<summary>
        ///  writes to the console the message “Payment verified“, and returns true. Need to be overloaded by derived classes if needed. 
        ///</summary>
        public virtual bool verify()
        {
            Console.WriteLine ("Payment Verified . . .");
            return true; 
        }

        ///<summary>
        /// has no implementation (abstract) in this class, and it need to be implemented in all derived classes. 
        ///</summary>
        public abstract string getPaymentType(); 
    }
}
