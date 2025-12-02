using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class User
    {
        internal double Balance {  get; set; }
        internal Good OrdingGood { get; }

        internal User(double balance, Good ordingGood) 
        {
            Balance = balance;
            OrdingGood = ordingGood;
        }


    }
}
