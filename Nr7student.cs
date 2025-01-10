using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr7
{
    public class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }


        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }


        public double CalculateAverage()
        {
            if (Grades.Length == 0) return 0;

            int sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }


        public void DisplayGrades()
        {
            Console.WriteLine($"{Name}'s Grades:");
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }

        }
    }
}
