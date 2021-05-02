using System;
using System.Collections.Generic;

namespace LW2.LW2_1
{
    abstract class DataGroupingTool<T>
    {
        public List<Employee> SourceData { get; private set; }
        public Dictionary<T, List<Employee>> GroupedData { get; private set; }

        protected Dictionary<T, List<Employee>> _grouppedData;

        public void GroupData(List<Employee> data)
        {
            Init(data);
            GroupedData = Group();
        }

        protected abstract Dictionary<T, List<Employee>> Group();

        private void Init(List<Employee> data)
        {
            SourceData = new List<Employee>(data);
            GroupedData = new Dictionary<T, List<Employee>>();
            _grouppedData = new Dictionary<T, List<Employee>>();
        }

        public void Print()
        {
            foreach (var group in GroupedData)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(group.Key);
                Console.ResetColor();

                foreach (var record in group.Value)
                {
                    Console.WriteLine("| {0,-2} | {1, -10} | {2, -6} | {3, -2} | {4, -2} |", record.Id, record.Name, record.Gender, record.Age, record.WorkExperience);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
