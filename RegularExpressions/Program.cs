using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....REGULAR EXPRESSSIONS.....");
            Console.WriteLine("choose the options");
            Console.WriteLine("\n1:Matches A \n2:LowerCase Sequence \n3:HTML Tag \n4:Occurance \n22:Default:");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Patterns.check();
                    break;
                case 2:
                    Patterns.LowerCaseSequence();
                    break;
                case 3:
                    Patterns.HTMLTag();
                    break;
                case 4:
                    Patterns.Occurences();
                    break;
                default:
                    Console.WriteLine("Enter the Above option");
                    break;
            }
                    Console.ReadLine();
        }
    }
}
