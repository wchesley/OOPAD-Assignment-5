using System;

namespace Assignment_5
{
    class Cash
    {
        double tenderdCash; 
        double change; 

        ///<summary>
        ///  updates the change attribute, and returns the change. Change = tenderedCash – payment amount. Note that amount in base class (Payment) is private (not protected and not public)
        ///</summary>
        double calcChange()
        {

        }

        ///<summary>
        ///  overrides the base abstract class method,returns the string “Cash” that represents the payment type of this class. To be used when displaying Payment types, like in getBillInfo()
        ///</summary>
        string getPaymentType()
        {

        }
    }
}