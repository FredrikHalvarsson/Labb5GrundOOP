namespace Labb5GrundOOP
{
    internal class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            bool run = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu:\n" +
                "1. Calculate Area\n" +
                "2. Calculate Circumference\n" +
                "0. Exit");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        Console.WriteLine("Input radius of the circle to calculate area.");
                        int rad = Convert.ToInt32(Console.ReadLine());
                        float area = circle.GetArea(rad);
                        Console.WriteLine(area);
                        Console.ReadLine();
                        break;
                    case "2": 
                        Console.WriteLine("Input radius of the circle to calculate the circumference.");
                        int rad2 = Convert.ToInt32(Console.ReadLine());
                        float circumference = circle.GetCircumference(rad2);
                        Console.WriteLine(circumference);
                        Console.ReadLine();
                        break;
                    case "0":
                        run = false;
                        break;
                }
            } while (run == true);
        }
    }
    public class Circle
    {
        float pi = 3.141f;
        int radius;

        public float GetArea(int radius=0)
        {
            float area = radius * radius * pi;
            return area;
        }
        public float GetCircumference(int radius = 0)
        {
            float circumference = radius * 2 * pi;
            return circumference;
        }
    }
}