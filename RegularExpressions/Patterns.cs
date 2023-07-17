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
        public static void LowerCaseSequence()
        {
            Console.WriteLine("enter the fitst name");
            string pattern = @"[a-z]+(_[a-z]+)";
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
        public static void HTMLTag()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = "<[^>]+>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        public static void Occurences()
        {
            string pattern = "fox(es)?";
            string input = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";
            Regex regex = new Regex(pattern);
            int count = regex.Matches(input).Count;

            Console.WriteLine($"There are {count} occurrences.");
        }
    }
}
