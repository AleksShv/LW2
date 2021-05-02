using System;

namespace LW2.LW2_2
{
    static class DataSort
    {
        public static void Invoke()
        {
            string[] mixedData = new string[] {
                "7", "7,4", "gear", "2,9", "6,6", "maze", "6", "whisper", "7", "1",
                "9", "drift", "9", "4,4", "6,3", "8,7", "5,8", "crackpot", "4,8", "4,7",
                "craftsman", "ankle", "8,4", "5", "3,9", "4", "7,2", "8", "5,7", "time"
            };

            string[] timePoints = new string[]
            {
                "22:33:18", "15:24:03", "01:56:14", "19:42:55", "17:44:32",
                "20:35:00", "12:34:14", "11:34:58", "09:29:53", "23:31:05",
                "20:18:06", "11:14:01", "04:23:25", "10:17:43", "21:27:25",
                "01:47:00", "02:43:12", "04:03:40", "07:27:46", "20:36:12",
            };

            PrintMixedData();
            MixedDataSort mixedSort = new MixedDataSort();
            mixedSort.SortAndPrint(ref mixedData);

            PrintTimePoints("Source Time Points");
            TimePointsSort pointSort = new TimePointsSort();
            pointSort.Sort(timePoints);
            PrintTimePoints("Sorted Time Points");

            void PrintMixedData()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Source Mixed Data");
                Console.ResetColor();

                for (int i = 0; i < mixedData.Length; i++)
                {
                    Console.Write($"{mixedData[i]} ");
                }
                Console.WriteLine();
            }

            void PrintTimePoints(string description)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(description);
                Console.ResetColor();

                foreach (var value in timePoints)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }
        }
    }
}
