﻿namespace _20.EnglishNameOfLastDigit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(GetLastDigitName(number));
        }

        private static string GetLastDigitName(string number)
        {
            long lastDigit = long.Parse(number[number.Length - 1].ToString());
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
            }

            return null;
        }
    }
}