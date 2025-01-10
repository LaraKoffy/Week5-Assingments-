using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr5
{
   public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }

      
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

       
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

}
