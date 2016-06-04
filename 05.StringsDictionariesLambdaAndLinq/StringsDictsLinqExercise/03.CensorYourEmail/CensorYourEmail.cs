namespace _03.CensorYourEmail
{
    using System;

    public class CensorYourEmail
    {
        public static void Main()
        {
            string emailAddress = Console.ReadLine();
            string text = Console.ReadLine();

            int indexOfMonkeyA = emailAddress.IndexOf('@');
            string censoredEmailAddress =
                new string('*', emailAddress.Substring(0, indexOfMonkeyA).Length) +
                emailAddress.Substring(indexOfMonkeyA);
            string censoredText = text.Replace(emailAddress, censoredEmailAddress);
            Console.WriteLine(censoredText);
        }
    }
}