using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Bank Account Interest Method Overriding:
// Extend the bank account class from the encapsulation problem statement to include a method for calculating interest. Override this method in derived classes such as "SavingsAccount" and "CurrentAccount" to implement interest calculation specific to each account type, demonstrating method overriding.


namespace BankAccountMethodOverridingg
{


    public class SavingsAccount: BankAccount 

    {

        public override void calculateInterest()
        {

            int principalAmount = 1000;
            int time = 2;
            int rateOfInterest = 2;

            double savingsAccountInterest = (principalAmount * time * rateOfInterest) / 100;
            Console.WriteLine("Savings Account Interest " + savingsAccountInterest);
            Console.WriteLine();

        }

       




    }
}
