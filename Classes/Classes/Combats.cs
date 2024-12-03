namespace Memory
{
    public class Combat
    {
        public List<Rate> RateLog { get; } = new();

        public void StartCombat(Unit unit1, Unit unit2)
        {
            bool unit1IsDead = false, unit2IsDead = false;

            while (!unit1IsDead && !unit2IsDead)
            {
                var random = new Random();
                var diceRoll = random.Next(1, 10);

                if (diceRoll % 2 == 0)
                {
                    unit1IsDead = unit1.SetDamage(unit2.Damage);
                    RateLog.Add(new Rate(unit1, (int)unit2.Damage, unit1.Health));
                }
                else
                {
                    unit2IsDead = unit2.SetDamage(unit1.Damage);
                    RateLog.Add(new Rate(unit2, (int)unit1.Damage, unit2.Health));
                }
            }

        }

        public void ShowResults()
        {
            foreach (var rate in RateLog)
            {
                Console.WriteLine($"Боец {rate.Unit.Name} нанёс урон {rate.Damage} и оставил {rate.Health} здоровья.");
            }
        }
    }
    public struct Interval
    {
        private float MinValue { get; }
        public float MaxValue { get; }

        public Interval(int minValue, int maxValue)
            : this((float)minValue, (float)maxValue)
        {
        }

        public Interval(float value)
            : this(value, value)
        {
        }

        public Interval(float minValue, float maxValue)
        {
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine($"Данные введены некорректно и были поменяны местами.");
            }

            MinValue = minValue;
            MaxValue = maxValue;
        }

        public float Min() => MinValue;
        public float Max() => MaxValue;
        public float Average() => (MinValue + MaxValue) / 2;

        public float Get()
        {
            var random = new Random();
            return random.NextSingle() * (MaxValue - MinValue);
        }
    }

    public struct Rate
    {
        public Unit Unit { get; }
        public int Damage { get; }
        public float Health { get; }

        public Rate(Unit unit,
            int damage,
            float health)
        {
            Unit = unit;
            Damage = damage;
            Health = health;
        }
    }

}