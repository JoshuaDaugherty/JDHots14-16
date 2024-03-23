using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ILoan
{
    public class ShortTermLoan : ILOAN
    {
        //instance
        decimal _MonthlyPayment;
        decimal _InterestRate;

        //constructor
        public ShortTermLoan(string Name, string Type, decimal Balance, 
                             decimal MonthlyPayment, decimal InterestRate)
            :base(Name, Type, Balance)
        {
            _MonthlyPayment = MonthlyPayment;
            _InterestRate = InterestRate;
        }

        //getters
        public decimal MonthlyPayment { get; }
        public decimal InterestRate { get; }

        public override void ApplyInterest()
        {
            throw new NotImplementedException();
        }

        public override void MakePayment()
        {
            decimal result  = 0.00m;
            const decimal SHORTPAY = 450.00m;
            decimal Amount = 0.00m;


            result = Amount - SHORTPAY;

        }

       
    }
}
