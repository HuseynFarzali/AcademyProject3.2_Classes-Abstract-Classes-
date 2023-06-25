using System;

namespace AcademyProject3._2_Classes_Abstract_Classes_
{

    class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private int Weight { get; set; }
        private int Height { get; set; }

        public Person()
        {
            Name = "(No name provided)";
            Surname = "(No surname provided)";
            Age = Weight = Height = int.MinValue;
        }
        public Person(string name, string surname, int age, int weight, int height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"Full Name -> {Name} {Surname}\n" +
                $"Age -> {Age}\n" +
                $"Weight -> {Weight} kg\n" +
                $"Height -> {Height} cm";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pr_def = new Person();
            Console.WriteLine(pr_def);

            Console.WriteLine();

            Person pr = new Person("Aliheydar", "Heydarov", 20, 71, 176);
            Console.WriteLine(pr); 
        }
    }
}
