using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
     public class AdmissionEligibility
    {
        public static void CheckEligiility()
        {
            Console.WriteLine("Enter Math mark");
            int MM=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics mark");
            int PM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry mark");
            int CM = Convert.ToInt32(Console.ReadLine());
            int TM = MM + PM + CM;
            Console.WriteLine("Total Marks are" +  TM);

            if (MM>=65 && PM>=55 && CM>=50 && TM>=180)
            {
                Console.WriteLine("Your eligible for taking admission");
            }
            else if ((MM+PM)>=140 || (MM+CM)>=140)
            {
                Console.WriteLine("Your eligible for taking admission");
            }
            else
            {
                Console.WriteLine("Your not eligible for taking admission");
            }
        }
    }
}
