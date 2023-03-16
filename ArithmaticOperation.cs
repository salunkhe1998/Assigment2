using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
    public class ArithmaticOperation
    {
        public static void ArithmaticOperation()
        {


            Console.Write("Enter Number1: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Number2: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Divsion");
            Console.WriteLine("4.Multiplication");
            int c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Division Of Two Numbers : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                    break;

                default:
                    Console.WriteLine("Choose Only 1 To 4 ");
                    break;

            }
        }
    }
}



    }
}
