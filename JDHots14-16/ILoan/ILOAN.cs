using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoan
{
    public abstract class ILOAN
    {
        //instance variables

        private string _Name;
        private string _Type;
        private decimal _Balance;

        //constructor
        public ILOAN (string Name, string Type, decimal Balance)
        {
            _Name = Name;
            _Type = Type;
            _Balance = Balance;
        }


        //getters
        public string Name { get; }
        public string Type { get; }
        public double Balance { get; }

        public abstract void MakePayment();
        public abstract void ApplyInterest();
    }
}
;