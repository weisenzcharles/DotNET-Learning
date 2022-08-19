using System;

namespace dotNetFive
{

    /// <summary>
    /// https://docs.microsoft.com/zh-cn/dotnet/csharp/whats-new/csharp-9#record-types
    /// </summary>
    class Program
    {

        public abstract record Person(string FirstName, string LastName);

        public record Teacher(string FirstName, string LastName, int Grade) : Person(FirstName, LastName);

        public record Student(string FirstName, string LastName, int Grade) : Person(FirstName, LastName);

        public static void Main()
        {
            Person teacher = new Teacher("Nancy", "Davolio", 3);
            Person student = new Student("Nancy", "Davolio", 3);
            Console.WriteLine(teacher == student); // output: False

            Student student2 = new("Nancy", "Davolio", 3);
            Console.WriteLine(student2 == student); // output: True
        }




        //public record Person(string FirstName, string LastName);

        //public static void Main()
        //{
        //    Person person = new("Nancy", "Davolio");
        //    Console.WriteLine(person.GetType());
        //    Console.WriteLine(person);
        //    // output: Person { FirstName = Nancy, LastName = Davolio }
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}
