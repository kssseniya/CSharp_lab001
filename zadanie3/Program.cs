namespace zadanie3
{
    public class Point
    {
        private int x;
        private int y;

        //Конструктор
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }

        //Свойство для получения координаты X
        public int X
        {
            get
            {
                return x; //Возвращает значение поля x
            }
        }

        //Свойство для получения координаты Y
        public int Y
        {
            get
            {
                return y; //Возвращает значение поля y
            }
        }
    }

    //Класс для представления фигуры
    public class Figure
    {
        
        private Point[] points; //Массив точек, определяющих фигуру

        //Конструктор для создания треугольника
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            (points[0], points[1], points[2]) = (p1, p2, p3);
            Name = "Треугольник";
        }

        //Конструктор для создания четырехугольника
        public Figure(Point p1, Point p2, Point p3, Point p4): this(p1, p2, p3)
        {
            points = new Point[4];
            points[3] = p4;
            Name = "Четырехугольник";
        }

        //Конструктор для создания пятиугольника
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5):this (p1,p2,p3,p4) 
        {
            points = new Point[5];
            points[4] = p5;
            Name = "Пятиугольник";
        }

        public string Name { get; set; }

        //Метод для расчета длины стороны фигуры
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            //Теорема Пифагора для расчета расстояния между точками
        }

        //Метод для расчета периметра фигуры
        public double PerimeterCalculator()
        {
            double perimeter = 0; //Инициализация периметра

            for (int i = 0; i < points.Length - 1; i++) //Цикл по всем точкам фигуры, кроме последней
            {
                perimeter += LengthSide(points[i], points[i + 1]); //Суммирование длин сторон
            }

            // Расчет длины последней стороны (от последней точки до первой)
            perimeter += LengthSide(points[points.Length - 1], points[0]);

            return perimeter; // Возвращение значения периметра
        }
    }

    // Класс программы
    public class Program
    {
        public static void Main(string[] args)
        {
            Figure figure;
            Point[] points = new Point[3];
            points[0] = new Point(0 ,0);
            points[1] = new Point(0, 4);
            points[2] = new Point(3, 0);
            figure = new Figure(points[0], points[1], points[2]);
            Console.WriteLine($"Фигура: {figure.Name}, Периметр: {figure.PerimeterCalculator()}");
        }
    }
}