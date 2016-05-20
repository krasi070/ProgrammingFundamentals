namespace _13.VowelOrDigit
{
    using System;

    public class VowelOrDigit
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());
            if (input >= '0' && input <= '9')
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'e' || input == 'o' || input == 'i' || input == 'u' ||
                input == 'A' || input == 'E' || input == 'O' || input == 'I' || input == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}