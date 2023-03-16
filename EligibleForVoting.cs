using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
    public class EligibleForVoting
    {
        public static void CheckEligibleVoting();
        {
        Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 18)
            {
            Console.WriteLine("Your are Eligible For Voting");
            }
         else
    {
         Console.WriteLine("Your are Not Eligible For Voting");
        }
    }
}

