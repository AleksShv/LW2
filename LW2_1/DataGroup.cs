using System;
using System.Collections.Generic;

namespace LW2.LW2_1
{
    static class DataGroup
    {
        public static void Invoke()
        {
            List<Employee> data = new List<Employee>()
            {
                new Employee("Михаил", Gender.Male, 24, 2),
                new Employee("Сергей", Gender.Male, 24, 4),
                new Employee("Майя", Gender.Female, 23, 2),
                new Employee("Арина", Gender.Female, 29, 9),
                new Employee("Максим", Gender.Male, 37, 15),
                new Employee("Тимофей", Gender.Male, 30, 8),
                new Employee("Кирилл", Gender.Male, 38, 17),
                new Employee("Василиса", Gender.Female, 37, 15),
                new Employee("Арина", Gender.Female, 40, 18),
                new Employee("Александра", Gender.Female, 27, 5),
                new Employee("София", Gender.Female, 25, 4),
                new Employee("Любовь", Gender.Female, 29, 9),
                new Employee("Елизавета", Gender.Female, 24, 1),
                new Employee("Даниил", Gender.Male, 24, 3),
                new Employee("Дмитрий", Gender.Male, 40, 15),
                new Employee("Ксения", Gender.Female, 31, 7),
                new Employee("Александр", Gender.Male, 33, 11),
                new Employee("Михаил", Gender.Male, 33, 10),
                new Employee("Святослав", Gender.Male, 27, 7),
                new Employee("Мария", Gender.Female, 26, 8),
            };

            Print();

            DataGroupingTool<Gender> dataGroup1;
            dataGroup1 = new QualityAttribute<Gender>();
            dataGroup1.GroupData(data);
            dataGroup1.Print();

            DataGroupingTool<string> dataGroup2;
            dataGroup2 = new QuantitativeAttribute<string>();
            dataGroup2.GroupData(data);
            dataGroup2.Print();

            List<Recipient> recipients = new List<Recipient>()
            {
                new Recipient("", 22),
                new Recipient("", 25),
                new Recipient("", 23),
                new Recipient("", 22),
                new Recipient("", 27),
                new Recipient("", 22),
                new Recipient("", 26),
            };

            

            void Print()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Source Data");
                Console.ResetColor();

                foreach (var record in data)
                {
                    Console.WriteLine("| {0,-2} | {1, -10} | {2, -6} | {3, -2} | {4, -2} |", record.Id, record.Name, record.Gender, record.Age, record.WorkExperience);
                }
                Console.WriteLine();
            }
        }
    }
}
