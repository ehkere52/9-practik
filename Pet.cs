namespace Praktik_9
{
    internal class Pet
    {
        private string name;
        private int energy;
        private bool activity;

        public Pet (string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public string Name
        {
            get { return name; }
            set { name = value.ToString(); }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    activity = false;
                }
                else
                {
                    this.energy = value;
                    activity = true;
                }
            }
        }
        public void Play()
        {
            if (!activity)
            {
                return;
            }
            else if (energy <= 20)
            {
                Console.WriteLine("Недстаточно энергии!");
                return;
            }
            energy -= 20;
            Console.WriteLine($"{name} играет, энергия {energy}");
        }
        public void Rest()
        {
            if (!activity)
            {
             
                return;
            }
            energy = energy + 20 > 100 ? 100 : energy += 20;
            Console.WriteLine($"{name} Отдыхает, энергия {energy}");

        }
    }
}
