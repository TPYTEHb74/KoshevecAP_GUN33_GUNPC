namespace Classes
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою:");

            Console.WriteLine("Введите имя бойца:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            if (!float.TryParse(Console.ReadLine(), out var health))
            {
                Console.WriteLine("Значение равно нулю.");
            }

            Console.WriteLine("Введите значение брони шлема от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var helmArmor))
            {
                Console.WriteLine("Значение равно нулю.");
            }

            Console.WriteLine("Введите значение брони кирасы от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var shellArmor))
            {
                Console.WriteLine("Значение равно нулю.");
            }

            Console.WriteLine("Введите значение брони сапог от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out var bootsArmor))
            {
                Console.WriteLine("Значение равно нулю.");
            }

            Console.WriteLine("Укажите минимальный урон оружия (1-10):");
            if (!float.TryParse(Console.ReadLine(), out var minWeaponDamage))
            {
                Console.WriteLine("Значение равно нулю.");
            }

            Console.WriteLine("Укажите максимальный урон оружия (10 и более):");
            if (!float.TryParse(Console.ReadLine(), out var maxWeaponDamage))
            {
                Console.WriteLine("Значение равно нулю.");
            }


            Unit player = new Unit(name);
            player.SetHealth(health);

            Helm playerHelm = new Helm("Player's Helm") { ArmorValue = helmArmor };
            Shell playerShell = new Shell("Player's Shell") { ArmorValue = shellArmor };
            Boots playerBoots = new Boots("Player's Boots") { ArmorValue = bootsArmor };

            Weapon playerWeapon = new Weapon("Player's Weapon", minWeaponDamage, maxWeaponDamage);

            player.EquipHelm(playerHelm);
            player.EquipShell(playerShell);
            player.EquipBoots(playerBoots);
            player.EquipWeapon(playerWeapon);


            Console.WriteLine($"Общий показатель брони равен: {player.Armor}");
            Console.WriteLine($"Фактическое значение здоровья равно: {player._Health}");
        }

    }
}