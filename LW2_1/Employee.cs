namespace LW2
{
    class Employee
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public Gender Gender { get; init; }
        public int Age { get; init; }
        public int WorkExperience { get; init; }

        private static int _globalId;

        public Employee(string name, Gender gender, int age, int workExperience)
        {
            Id = _globalId++;
            Name = name;
            Gender = gender;
            Age = age;
            WorkExperience = workExperience;
        }
    }
}
