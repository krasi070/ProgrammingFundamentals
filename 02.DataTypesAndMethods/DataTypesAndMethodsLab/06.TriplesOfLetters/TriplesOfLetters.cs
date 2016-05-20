namespace _06.TriplesOfLetters
{
    using System;

    public class TriplesOfLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char j = 'a'; j < 'a' + n; j++)
                {
                    for (char k = 'a'; k < 'a' + n; k++)
                    {
                        Console.WriteLine(i.ToString() + j.ToString() + k.ToString());
                    }
                }
            }
        }
    }
}