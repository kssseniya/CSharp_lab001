namespace zadanie2
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        // Конструктор
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        // Метод для вычисления площади
        private double CalculateArea()
        {
            return sideA * sideB;
        }

        // Метод для вычисления периметра
        private double CalculatePerimeter()
        {
            return 2 * (sideA + sideB);
        }

        // Свойство для площади
        public double Area
        {
            get
            {
                return CalculateArea();
            }
        }

        // Свойство для периметра
        public double Perimeter
        {
            get
            {
                return CalculatePerimeter();
            }
        }
    }

    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
        }
    }
}