using System.Text.RegularExpressions;

namespace LW2.LW2_2
{
    class TimePointsSort
    {
        public void Sort(string[] arr)
        {
            Quicksort(arr, 0, arr.Length - 1);
        }

        private void Quicksort(string[] arr, int start, int end)
        {
            if (start >= end)
                return;

            var pivot = Partition(arr, start, end);
            Quicksort(arr, start, pivot - 1);
            Quicksort(arr, pivot + 1, end);
        }

        private int Partition(string[] arr, int start, int end)
        {
            string temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {


                if (GetTime(arr[i]) < GetTime(arr[end]))
                {
                    temp = arr[marker];
                    arr[marker] = arr[i];
                    arr[i] = temp;
                    marker += 1;
                }
            }

            temp = arr[marker];
            arr[marker] = arr[end];
            arr[end] = temp;
            return marker;
        }

        private int GetTime(string timePoint)
        {
            var hh = int.Parse(Regex.Match(timePoint, "^\\d+").Value);
            var mm = int.Parse(Regex.Match(timePoint, ":\\d+:").Value.Replace(':', ' ').Trim());
            var ss = int.Parse(Regex.Match(timePoint, "\\d+$").Value);

            var time = ss + mm * 60 + hh * 3600;

            return time;
        }
    }
}
