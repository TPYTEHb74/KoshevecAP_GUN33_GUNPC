namespace Memory
{
    internal class Program

    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Подготовка к бою:");

            Console.WriteLine("Введите имя бойца:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите начальное здоровье бойца (10 - 100):");
            if (!float.TryParse(Console.ReadLine(), out var baseHealth))
            {
                Console.WriteLine("Значение обнулено.");
            }

            var unit = new Unit(name, baseHealth);

            Console.WriteLine("Введите значение брони шлема от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var helmArmor))
            {
                Console.WriteLine("Значение обнулено.");
            }

            var helm = new Helm { Armor = helmArmor };
            unit.EquipHelm(helm);

            Console.WriteLine("Введите значение брони кирасы от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var shellArmor))
            {
                Console.WriteLine("Значение обнулено.");
            }

            var shell = new Shell { Armor = shellArmor };
            unit.EquipShell(shell);

            Console.WriteLine("Введите значение брони сапог от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var bootsArmor))
            {
                Console.WriteLine("Значение обнулено.");
            }

            var boots = new Boots { Armor = bootsArmor };
            unit.EquipBoots(boots);

            Console.WriteLine("Укажите минимальный урон оружия (1 - 10):");
            if (!float.TryParse(Console.ReadLine(), out var minDamage))
            {
                Console.WriteLine("Нулевое значение.");
            }

            Console.WriteLine("Укажите максимальный урон оружия (10 - 40):");
            if (!float.TryParse(Console.ReadLine(), out var maxDamage))
            {
                Console.WriteLine("Значение обнулено.");
            }

            var weapon = new Weapon(minDamage, maxDamage);
            unit.EquipWeapon(weapon);

            Console.WriteLine($"Общий показатель брони равен: {unit.Armor}");
            Console.WriteLine($"Фактическое значение здоровья равно: {unit.GetRealHealth()}");

            var unit1 = new Unit("Unit 1", 20);
            var unit2 = new Unit("Unit 2", 20);

            unit1.EquipWeapon(weapon);

            unit2.EquipHelm(helm);
            unit2.EquipBoots(boots);
            unit2.EquipShell(shell);

            Console.WriteLine("Боец 1:");
            Console.WriteLine($"{unit1.Name}: здоровье {unit1.Health}, урон {unit1.Damage}");

            Console.WriteLine("Боец 2:");
            Console.WriteLine($"{unit2.Name}: здоровье {unit2.Health}, урон {unit2.Damage}");

            var combat = new Combat();

            combat.StartCombat(unit1, unit2);
            combat.ShowResults();

            Console.WriteLine("Бой окончен.");
        }

    }
}
