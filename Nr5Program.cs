using System;

namespace Nr5
{
    internal class Program
    {
        static void Start()
        {
            
           Person[] persons = new Person[3];

           
            for (int i = 0; i < persons.Length; i++)
            {
               
                Console.WriteLine($"Enter the name for person {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the age for person {i + 1}:");
                int age = int.Parse(Console.ReadLine());

                
                persons[i] = new Person(name, age);
            }

           
            PrintPersonArray(persons);
        }

       
        static void PrintPersonArray(Person[] persons)
        {
            Console.WriteLine("\nPerson Information:");
            foreach (var person in persons)
            {
                person.DisplayPersonInfo();
            }
        }

        static void Main(string[] args)
        {
         
            Start();
        }
}
