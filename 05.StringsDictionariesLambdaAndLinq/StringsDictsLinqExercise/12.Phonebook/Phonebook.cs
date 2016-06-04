namespace _12.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] args = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string command = args[0];
                string name = args[1];
                if (command == "A")
                {
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
                else
                {
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}