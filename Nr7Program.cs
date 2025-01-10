
namespace Nr7
{
    internal class Program
    {

        tatic void Main(string[] args)
        {
         
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter the number of grades to process: ");
            int numGrades;
            while (!int.TryParse(Console.ReadLine(), out numGrades) || numGrades <= 0)
            {
                Console.Write("Please enter a valid number of grades: ");
            }

            
            int[] grades = new int[numGrades];

           
            for (int i = 0; i < numGrades; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
                {
                    Console.Write("Please enter a valid grade (0-100): ");
                }
            }

            
            Student student = new Student(studentName, grades);

           
            student.DisplayGrades();
            double average = student.CalculateAverage();
            Console.WriteLine($"Average grade for {student.Name}: {average:F2}");
        }
}
