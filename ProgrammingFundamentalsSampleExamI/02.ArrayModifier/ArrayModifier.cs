namespace _02.ArrayModifier
{
    using System;
    using System.Linq;

    public class ArrayModifier
    {
        public static void Main()
        {
            long[] arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string type = commandArgs[0];
                int index1 = 0;
                int index2 = 0;
                if (commandArgs.Length > 1)
                {
                    index1 = int.Parse(commandArgs[1]);
                    index2 = int.Parse(commandArgs[2]);
                }

                switch (type)
                {
                    case "swap":
                        ExecuteSwapCommand(arr, index1, index2);
                        break;
                    case "multiply":
                        arr[index1] *= arr[index2];
                        break;
                    case "decrease":
                        ExecuteDecreaseCommand(arr);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        private static void ExecuteSwapCommand(long[] arr, int index1, int index2)
        {
            long temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        private static void ExecuteDecreaseCommand(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}