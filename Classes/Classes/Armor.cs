namespace Classes
{
    // Класс представления шлема
    class Helm
    {
        public string Name { get; }
        private float armorValue; // Значение брони
        public float ArmorValue
        {
            get => armorValue;
            set
            {
                if (value < 0f)
                {
                    armorValue = 0f;
                    Console.WriteLine($"Показатель брони шлема был округлен до 0.");
                }
                else if (value > 1f)
                {
                    armorValue = 1f;
                    Console.WriteLine($"Показатель брони шлема был округлен до 1.");
                }
                else
                {
                    armorValue = value;
                }
            }
        }

        public Helm(string name)
        {
            Name = name;
        }
    }

    // Класс представления кирасы
    class Shell
    {
        public string Name { get; }
        private float armorValue;
        public float ArmorValue
        {
            get => armorValue;
            set
            {
                if (value < 0f)
                {
                    armorValue = 0f;
                    Console.WriteLine($"Показатель брони кирасы был округлен до 0.");
                }
                else if (value > 1f)
                {
                    armorValue = 1f;
                    Console.WriteLine($"Показатель брони кирасы был округлен до 1.");
                }
                else
                {
                    armorValue = value;
                }
            }
        }

        public Shell(string name)
        {
            Name = name;
        }
    }

    // Класс представления сапог
    class Boots
    {
        public string Name { get; }
        private float armorValue;
        public float ArmorValue
        {
            get => armorValue;
            set
            {
                if (value < 0f)
                {
                    armorValue = 0f;
                    Console.WriteLine($"Показатель брони сапог был округлен до 0.");
                }
                else if (value > 1f)
                {
                    armorValue = 1f;
                    Console.WriteLine($"Показатель брони сапог был округлен до 1.");
                }
                else
                {
                    armorValue = value;
                }
            }
        }
        // Конструктор класса сапог
        public Boots(string name)
        {
            Name = name;
        }
    }
}