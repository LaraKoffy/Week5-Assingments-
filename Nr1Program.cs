namespace Nr1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            double height = Convert.ToDouble(Console.ReadLine());


            Rectangle rectangle = new Rectangle(width, height);


            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();


            Console.WriteLine($"The area of the rectangle is: {area}");
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
        }
    }
}
