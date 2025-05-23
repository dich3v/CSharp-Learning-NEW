﻿namespace Task27_SumPairsfromList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string result = SumPairs(list);

            Console.WriteLine(result);
        }

        public static string SumPairs(List<int> list)
        {
            List<int> result = new List<int>();

            int lastElement = list.Count - 1;

            for (int i = 0; i < list.Count / 2; i++)
            {
                result.Add(list[i] + list[lastElement - i]);
            }
            if (list.Count % 2 != 0)
            {
                result.Add(list[list.Count / 2]);
            }
            return string.Join(" ", result);
        }
    }
}
