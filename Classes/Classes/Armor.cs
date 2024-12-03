namespace Memory
{
    public abstract class Armors
    {
        public Armors()
        {
            Name = GetDefaultName();
        }

        public Armors(string name)
        {
            Name = name;
        }

        protected abstract string GetDefaultName();

        public string Name { get; }

        private float ArmorValue;

        public float Armor
        {
            get => ArmorValue;
            init
            {
                ArmorValue = Math.Clamp(value, 0f, 10f);
                if (value is < 0f or > 10f)
                {
                    Console.WriteLine("Значение брони было задано некорректно.");
                }
            }
        }
    }

    public class Shell : Armors
    {
        public Shell() : base()
        {
        }

        public Shell(string? name) : base(name)
        {
        }

        protected override string GetDefaultName() => nameof(Shell);
    }

    public class Helm : Armors
    {
        public Helm() : base()
        {
        }

        public Helm(string? name) : base(name)
        {
        }

        protected override string GetDefaultName() => nameof(Helm);
    }

    public class Boots : Armors
    {
        public Boots() : base()
        {
        }

        public Boots(string? name) : base(name)
        {
        }

        protected override string GetDefaultName() => nameof(Boots);
    }
}