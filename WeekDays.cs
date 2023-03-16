using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay2
{
    public class WeekDays
    {
        public static void CheckWeekday()
        {
            Console.WriteLine("enter the  number between 1 and 7");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
            case1:
            Console.WriteLine("Monday");
            break;
        case2:
            Console.WriteLine("Tuesday");
            break;
        case3:
            Console.WriteLine("Wensday");
            break;
        case4:
            Console.WriteLine("Thursday");
            break;
        case5:
            Console.WriteLine("Friday");
            break;
        case6:
            Console.WriteLine("Saturday");
            break;
        case7:
            Console.WriteLine("Sunday");
            break;
            default;
            Console.WriteLine("The days btw 1 to 7");
            break;
        }
    }


}
    }
}
