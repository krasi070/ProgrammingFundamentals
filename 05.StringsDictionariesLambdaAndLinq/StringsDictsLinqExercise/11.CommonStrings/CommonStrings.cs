namespace _11.CommonStrings
{
    using System;

    public class CommonStrings
    {
        public static void Main()
        {
            string textA = Console.ReadLine();
            string textB = Console.ReadLine();
            for (int i = 0; i < textA.Length; i++)
            {
                if (textB.Contains(textA[i].ToString()))
                {
                    Console.WriteLine("yes");
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}