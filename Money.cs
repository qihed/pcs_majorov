using System;

class Money
{
    public static void Run()
    {
        Console.WriteLine("Сколько вы хотите обналичить?");
        while (true)
        {
            Console.Write("Введите число (или exit): ");
            string? input = Console.ReadLine();

            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (!int.TryParse(input, out int x))
            {
                Console.WriteLine("Ошибка: нужно ввести целое число!");
                continue;
            }

            if (x < 100 || x % 100 != 0)
            {
                Console.WriteLine("Сумма должна быть не меньше 100 и кратна 100.");
                continue;
            }

            Console.WriteLine($"Вы ввели: {x}");
            // Здесь — логика выдачи денег
            break; // или continue, если нужно повторять
        }
    }
}
