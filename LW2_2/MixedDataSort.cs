using System;
using System.Linq;


namespace LW2.LW2_2
{
    class MixedDataSort
    {
        public void SortAndPrint(ref string[] arr)
        {
            var intLine = arr.Where(x => int.TryParse(x, out int result))
                .OrderBy(x => x)
                .ToArray();

            var doubleLine = arr.Where(x => double.TryParse(x, out double result))
                .Except(intLine)
                .OrderBy(x => x)
                .ToArray();

            var stringLine = arr.Except(intLine.Concat(doubleLine))
                .OrderBy(x => x)
                .ToArray();

            arr = intLine.Concat(doubleLine).Concat(stringLine).ToArray();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted Mixed Data");
            Console.ResetColor();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0, -10}", arr[i]);

                if (i == intLine.Length - 1 || i == intLine.Length + doubleLine.Length - 1)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
