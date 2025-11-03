namespace Praktik_9
{

    internal class Phone
    {
        private string brand;
        private int batteryLevel;
        public Phone(string brand, int batteryLevel)
        {
            this.brand = brand;
            if (batteryLevel > 0)
            {
                this.batteryLevel = batteryLevel;
            }
            else
            {
                Console.WriteLine("некоректное значение!");
            }
        }

        public void UsePhone()
        {
            if (batteryLevel > 0)
            {
                batteryLevel -= 10;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Телефон {brand}. заряд: {batteryLevel}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Телефон разряжен!");
                Console.ResetColor();
            }
        }
    }
}
