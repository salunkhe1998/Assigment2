﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
    public class FactorialofNumber
    { 
            public static void factorial()
            {
                int i, f = 1, num;

                Console.Write("Input the number : ");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= num; i++)
                {
                    f = f * i;
                }
                Console.Write("The Factorial of {0} is: {1}\n", num, f);
            }
        }

}
