// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva

using System;
using System.Collections.Generic;


namespace Assignment_5
{
    class Bill
    {
        public Bill(string date, string desc, double Amount )
        {
            billDate = date;
            description = desc;
            amounts = Amount;
        }
        string billDate;
        string description;
        //bill total amount: 
        double amounts; 

        List<Payment> payments = new List<Payment>();


        ///<summary>
        ///  returns string contains all information in the bill including the payments. See the main() method and sample output to see what information is returned and then printed. 
        ///</summary>
        public string getBillInfo()
        {
            string billInfo = $"Date:{billDate}";
                foreach(var p in payments)
                    {
                        billInfo+=$"\nOn {p.getPaymentDate()} payment with {p.getPaymentType()} the amount ${p.amounts} was processed.";
                    }
                    billInfo+=$"\n Total amount paid: {getAmountPaid()}\n Remaining Balance: {getBalance()}";
            return billInfo; 
        }
        
        ///<summary>
        ///  calculate the remaining balance by calculating the difference between the total of payments and the bill’s original amount
        ///</summary>
        public double getBalance()
         {   
        double total=0;
        foreach(var a in payments)
        {
            total=total+getAmountPaid();
            //return Total;
        }
        return amounts - getAmountPaid();
    }


        public double getAmountPaid()
        {
        double total=0;
        foreach(var a in payments)
        {
            total=total+a.getAmount();
        }
        return total;
        } 
        ///<summary>
        ///  It calls verify() method first, and if verify is successful it adds the payment to the bill payments
        ///</summary>
        public bool addPayment(Payment p)
        {
            if(p.verify()==true) 
            {
                payments.Add(p);
                return true;
            }
            return false;
                }
    }
}