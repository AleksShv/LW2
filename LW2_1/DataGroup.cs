using System;
using System.Collections.Generic;

namespace LW2.LW2_1
{
    static class DataGroup
    {
        public static void Invoke()
        {
            List<Employee> employees = new List<Employee>()
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

            PrintEmployee();

            IGroupingTool groupTool;

            groupTool = new QualityAttribute();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gender");
            var groups = groupTool.Group(employees, nameof(Employee.Gender));
            PrintEmploeeGroup(groups);

            groupTool = new QuantitativeAttribute();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Age");
            groups = groupTool.Group(employees, nameof(Employee.Age));
            PrintEmploeeGroup(groups);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Work Expirience");
            groups = groupTool.Group(employees, nameof(Employee.WorkExperience));
            PrintEmploeeGroup(groups);

            List<Recipient> recipients = new List<Recipient>()
            {
                new Recipient("Елизавета", 22),
                new Recipient("Ксения", 25),
                new Recipient("Святослав", 23),
                new Recipient("Мария", 22),
                new Recipient("София", 27),
                new Recipient("Арина", 22),
                new Recipient("Михаил", 26),
            };

            PrintRecipient();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Annual Income");
            var groups1 = groupTool.Group(recipients, nameof(Recipient.AnnualIncome));
            PrintRecipientsGroup(groups1);

            void PrintEmployee()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Source Data");
                Console.ResetColor();

                foreach (var record in employees)
                {
                    Console.WriteLine("| {0,-2} | {1, -10} | {2, -6} | {3, -2} | {4, -2} |", record.Id, record.Name, record.Gender, record.Age, record.WorkExperience);
                }
                Console.WriteLine();
            }

            void PrintRecipient()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Source Data");
                Console.ResetColor();

                foreach (var record in recipients)
                {
                    Console.WriteLine("| {0,-2} | {1, -10} | {2, -2} |", record.Id, record.Name, record.AnnualIncome);
                }
                Console.WriteLine();
            }

            void PrintEmploeeGroup(Dictionary<object, List<Employee>> groups)
            {
                foreach (var group in groups)
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

            void PrintRecipientsGroup(Dictionary<object, List<Recipient>> groups)
            {
                foreach (var group in groups)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(group.Key);
                    Console.ResetColor();

                    foreach (var record in group.Value)
                    {
                        Console.WriteLine("| {0,-2} | {1, -10} | {2, -2} |", record.Id, record.Name, record.AnnualIncome);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
