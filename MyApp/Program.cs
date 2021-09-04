using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = GetUserInput();
            bool isParsed = false;
            while (!isParsed) {
                int year;
                isParsed = Int32.TryParse(input, out year);

                if (isParsed) {
                    PrintIsLeapYear(year);
                    return;
                }
                input = GetUserInput();
            }
        }

        public static bool IsLeapYear(int year) {
            if (year < 1582) {
                throw new ArgumentException("Year must pre-date 1582");
            }
            if (year % 100 == 0 && year % 400 == 0) {
                return true;
            } else if (year % 100 == 0) {
                return false;
            } else if (year % 4 == 0) {
                return true;
            }
            return false;
        }

        public static String GetUserInput() {
            Console.WriteLine("Enter a year:");
            Console.Write("> ");

            return Console.ReadLine();
        }

        public static void PrintIsLeapYear(int year) {
            bool isLeapYear;
            try {
                isLeapYear = IsLeapYear(year);
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
                return;
            }

            if (IsLeapYear(year)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }
    }
}