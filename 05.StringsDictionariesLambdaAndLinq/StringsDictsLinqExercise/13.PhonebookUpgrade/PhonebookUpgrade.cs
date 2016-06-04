namespace _13.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] args = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string command = args[0];
                if (command == "A")
                {
                    string name = args[1];
                    string number = args[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }
                }
                else if (command == "S")
                {
                    string name = args[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var phoneEntry in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", phoneEntry.Key, phoneEntry.Value);
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}