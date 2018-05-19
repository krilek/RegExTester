using System;
using System.Text.RegularExpressions;

namespace RegExTester {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hi, enter regex and then string to test, Press ESC to exit!");
            do {
                while (!Console.KeyAvailable) {
                    Console.WriteLine (@"Enter regex or press enter to use default (^[a-z]+$): ");
                    string regExString = Console.ReadLine ();

                    if (string.IsNullOrEmpty (regExString)) {
                        regExString = @"^[a-z]+$";
                    }
                    var patternMatcher = new Regex (regExString);
                    Console.WriteLine ($"Entered regEx {regExString} \nEnter string to test");
                    string testString = Console.ReadLine ();
                    while (string.IsNullOrEmpty (testString)) {
                        testString = Console.ReadLine ();
                    }
                    Console.WriteLine ($"{testString} matches {regExString}? {patternMatcher.IsMatch(testString).ToString()}");
                }
            } while (Console.ReadKey (true).Key != ConsoleKey.Escape);
            Console.WriteLine ("Exiting");
        }
    }
}