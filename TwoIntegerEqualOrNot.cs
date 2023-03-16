using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
    public class TwoIntegerEqualOrNot
    {
        public static void CheckEqualOrNot()
        {


            int num1, num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }

            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }

            Console.ReadLine();

        }
    }
}
