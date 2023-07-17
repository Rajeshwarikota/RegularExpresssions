﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Patterns
    {
        public static void check()
        {
            Console.WriteLine("enter the input to check");
            string pattern = "^a{1}b{2,3}";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                Console.WriteLine("Input string matches the pattern");
            }
            else
            {
                Console.WriteLine("Input string not matches the pattern");
            }
        }
    }
}
