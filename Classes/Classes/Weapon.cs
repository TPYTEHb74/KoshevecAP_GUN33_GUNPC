namespace Classes
{
    class Weapon
    {
        public string Name { get; }
        public float MinDamage { get; private set; }
        public float MaxDamage { get; private set; }

        // Конструкторы
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, float minDamage, float maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        // Установка параметров урона
        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage)
            {
                var temp = MinDamage;
                minDamage = maxDamage;
                maxDamage = temp;
                Console.WriteLine($"Некорректные входные данные для {Name}: " +
                    $"minDamage больше maxDamage. Значения были поменяны местами.");
            }

            if (minDamage < 1f)
            {
                MinDamage = 1f;
                Console.WriteLine($"Минимальный урон для {Name} был форсирован до 1f.");
            }

            if (maxDamage <= 1f)
            {
                MaxDamage = 10f;
                Console.WriteLine($"Максимальный урон для {Name} был установлен до 10f.");
            }

            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        // Получение урона
        public float GetDamage()
        {
            return (MinDamage + MaxDamage) / 2f;
        }
    }
}