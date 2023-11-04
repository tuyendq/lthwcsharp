namespace AbstractDemo
{
    public class Program
    {
        static void Main()
        {
            // Rectangle class
            Rectangle rect1 = new Rectangle(10, 20);
            System.Console.WriteLine(rect1.GetArea());

            // Circle class
            Circle circle1 = new Circle(3.5);
            System.Console.WriteLine(circle1.GetArea());
        }
    }
}

