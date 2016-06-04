namespace _10.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "print")
            {
                string[] args = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string commandType = args[0];
                switch (commandType)
                {
                    case "add":
                        ExecuteAddCommand(args, numbers);
                        break;
                    case "addMany":
                        ExecuteAddManyCommand(args, numbers);
                        break;
                    case "contains":
                        int searchedElement = int.Parse(args[1]);
                        Console.WriteLine(numbers.IndexOf(searchedElement));
                        break;
                    case "remove":
                        int indexOfElementToRemove = int.Parse(args[1]);
                        numbers.RemoveAt(indexOfElementToRemove);
                        break;
                    case "shift":
                        ExecuteShiftCommand(args, numbers);
                        break;
                    case "sumPairs":
                        ExecuteSumPairsCommand(numbers);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void ExecuteAddCommand(string[] args, List<int> numbers)
        {
            int addIndex = int.Parse(args[1]);
            int element = int.Parse(args[2]);
            numbers.Insert(addIndex, element);
        }

        private static void ExecuteAddManyCommand(string[] args, List<int> numbers)
        {
            int addManyIndex = int.Parse(args[1]);
            List<int> numbersToAdd = args
                .Skip(2)
                .Select(int.Parse)
                .ToList();
            numbers.InsertRange(addManyIndex, numbersToAdd);
        }

        private static void ExecuteShiftCommand(string[] args, List<int> numbers)
        {
            int positions = int.Parse(args[1]) % numbers.Count;
            List<int> firstSublist = numbers.GetRange(0, positions);
            List<int> secondSublist = numbers.GetRange(positions, numbers.Count - positions);
            numbers.Clear();
            numbers.AddRange(secondSublist);
            numbers.AddRange(firstSublist);
        }

        private static void ExecuteSumPairsCommand(List<int> numbers)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count; i += 2)
            {
                if (numbers.Count % 2 == 0 || i < numbers.Count - 1)
                {
                    newList.Add(numbers[i] + numbers[i + 1]);
                }
                else
                {
                    newList.Add(numbers[i]);
                }
            }

            numbers.Clear();
            numbers.AddRange(newList);
        }
    }
}