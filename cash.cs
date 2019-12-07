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
            this.change=amounts-t;


        }

        public double CalcChange()
        {
            this.change = this.tenderdCash - this.amounts;
            return this.change;
        }

        public override string getPaymentType()
        {
            return "Cash";
        }

    }
}
