using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
   public class ReverseNumber
    {
        public static void CheckReverseNumber()
        {
            int Reverse = 0;
            Console.WriteLine("Enter the number :");

            int num = Convert.ToInt32(Console.ReadLine());
            //while(num>0)

            for (int i = num; num > 0; i++)
            {
                int Reminder = num % 10;
                Reverse = Reverse * 10 + Remainder;
                num = num / 10;
            }
            Console.WriteLine(Reverse);

        }
    }
}
