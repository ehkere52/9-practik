namespace Praktik_9
{
    internal class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("некоректное значение!");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Circle(double value)
        {
            Radius = value;
        }
        public void GetArea()
        {
            if (radius > 0)
            {
                Console.WriteLine($"Площадь круга: {Math.PI * radius * radius} ");
            }
        }
    }
}
