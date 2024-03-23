using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoan
{
    public class LongTermLoan : ILOAN
    {
        //instance variables
        decimal _LMonthlyPayment;
        decimal _LInterestRate;

        //constructor
        public LongTermLoan(string Name, string Type, decimal Balance,
                            decimal LMonthlyPayment, decimal LInterestRate)
           :base (Name, Type, Balance)
        {
            _LMonthlyPayment = LMonthlyPayment;
            _LInterestRate = LInterestRate;
        }

        //getters
        public decimal LMonthlyPayment { get; }
        public decimal LInterestRate { get; }

        public override void ApplyInterest()
        {
            throw new NotImplementedException();
        }

        public override void MakePayment()
        {
            throw new NotImplementedException();
        }
    }
}
