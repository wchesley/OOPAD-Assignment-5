// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva
// 2 - Class Cash

using System;

namespace Assignment_5
{
    class Cash : Payment
    {

        double tenderdCash;
        double change;

        public Cash(double a, string d, double t) : base(a, d)
        {

            this.tenderdCash = t;

        }

        public double CalcChange()
        {
            return tenderdCash - Payment.getAmount();
        }

        public override string getPaymentType()
        {
            return "Cash";
        }

    }
}
