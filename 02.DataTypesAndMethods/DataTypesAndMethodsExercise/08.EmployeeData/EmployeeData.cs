namespace _08.EmployeeData
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string employeeNumber = Console.ReadLine();
            Console.WriteLine(
                "First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
                firstName,
                lastName,
                age,
                gender,
                id,
                employeeNumber);
        }
    }
}