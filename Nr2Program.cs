using static Nr2.day;

namespace Nr2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a day of the week (e.g., Monday, Tuesday, etc.):");
            string input = Console.ReadLine();

           
            if (Enum.TryParse(input, true, out Day day))
            {
                
                switch (day)
                {
                    case Day.Monday:
                        Console.WriteLine("Start of the work week!");
                        break;
                    case Day.Tuesday:
                        Console.WriteLine("Second day, keep going!");
                        break;
                    case Day.Wednesday:
                        Console.WriteLine("Midweek already!");
                        break;
                    case Day.Thursday:
                        Console.WriteLine("Almost there!");
                        break;
                    case Day.Friday:
                        Console.WriteLine("TGIF! The weekend is near!");
                        break;
                    case Day.Saturday:
                        Console.WriteLine("Enjoy your weekend!");
                        break;
                    case Day.Sunday:
                        Console.WriteLine("Relax, it's Sunday!");
                        break;
                    default:
                        Console.WriteLine("Invalid day entered.");
                        break;
                }
            }
        }
    }
}