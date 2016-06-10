namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berryPricePerKilo = decimal.Parse(Console.ReadLine());

            int portions = numberOfGuests;
            while (portions % 6 != 0)
            {
                portions++;
            }

            portions /= 6;
            decimal totalAmount = portions*(2*bananaPrice + 4*eggPrice + 0.2m*berryPricePerKilo);
            if (cash - totalAmount >= 0)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalAmount);   
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", totalAmount - cash);
            }
        }
    }
}