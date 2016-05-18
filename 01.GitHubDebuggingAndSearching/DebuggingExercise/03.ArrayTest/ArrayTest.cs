namespace _03.ArrayTest
{
    using System;
    using System.Linq;

    public class ArrayTest
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] args = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string commandType = args[0];
                int[] iArgs = new int[2];

                if (commandType.Equals("add") ||
                    commandType.Equals("subtract") ||
                    commandType.Equals("multiply"))
                {
                    int index = int.Parse(args[1]);
                    int value = int.Parse(args[2]);
                    iArgs[0] = index;
                    iArgs[1] = value;
                }

                PerformAction(array, commandType, iArgs);

                Console.WriteLine(string.Join(" ", array));

                command = Console.ReadLine();
            }
        }

        private static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;
        }
    }
}