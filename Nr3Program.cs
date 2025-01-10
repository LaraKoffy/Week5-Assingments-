namespace Nr3
{
    internal class Program
    {
        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

     
        static double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length;
        }

        static void Main(string[] args)
        {
          
            int[] numbers = new int[3];

          
            Console.WriteLine("Enter 3 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                while (true) 
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        numbers[i] = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
            }

            
            int sum = CalculateSum(numbers);
            double average = CalculateAverage(numbers);

            Console.WriteLine($"\nSum of the numbers: {sum}");
            Console.WriteLine($"Average of the numbers: {average:F2}");
        }
    }
}
