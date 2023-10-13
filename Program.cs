namespace Labb5GrundOOP
{
    internal class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            bool run = true;
            //Loop för att hålla programmet igång.
            do
            {
                //Meny med val för att räkna ut area eller omkrets på cirkel med inmatad radie.
                Console.Clear();
                Console.WriteLine("Menu:\n" +
                "1. Calculate Area\n" +
                "2. Calculate Circumference\n" +
                "3. Calculate Area of triangle" +
                "0. Exit");

                
                

                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        Console.WriteLine("Input radius of the circle to calculate area.");
                        int rad = Convert.ToInt32(Console.ReadLine());
                        float area = circle.GetArea(rad);
                        Console.WriteLine($"The area of your circle is {area}");
                        Console.ReadLine();
                        break;
                    case "2": 
                        Console.WriteLine("Input radius of the circle to calculate the circumference.");
                        int rad2 = Convert.ToInt32(Console.ReadLine());
                        float circumference = circle.GetCircumference(rad2);
                        Console.WriteLine($"The circumference of your circle is {circumference}");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Input triange base");
                        int tempBase= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input triangle height");
                        int tempHeight= Convert.ToInt32(Console.ReadLine());
                        Triangle triangle = new Triangle(tempBase, tempHeight);
                        Console.WriteLine($"the area of your triangle is {triangle.GetArea()}");
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
        //Konstruktor.
        float pi = 3.141f;
        int radius;

        //Metod för area.
        public float GetArea(int radius=0)
        {
            float area = radius * radius * pi;
            return area;
        }
        //Metod för omkrets.
        public float GetCircumference(int radius = 0)
        {
            float circumference = radius * 2 * pi;
            return circumference;
        }
    }
    public class Triangle
    {
        int _base;
        int _height;
        public Triangle(int basis, int height)
        {
            _base = basis;
            _height = height;
        }
        public float GetArea()
        {
            float area = _base * _height / 2;
            return area;
        }
    }
}