using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMethodOverridingg
{
    public class CurrentAccount:BankAccount
    {

        public override void calculateInterest()
        {
            int principalAmount = 2000;
            int time = 2;
            int rateOfInterest = 2;
            double currentAccountAmount= (principalAmount * time * rateOfInterest)/100;
            Console.WriteLine("Current Account Interest " + currentAccountAmount);
            Console.ReadKey();

        }


    }
}
