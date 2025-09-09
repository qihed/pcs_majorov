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

            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase)) //проверки
                break;

            if (!int.TryParse(input, out int x))
            {
                Console.WriteLine("Ошибка: нужно ввести целое число!");
                continue;
            }

            if (x < 100 || x % 100 != 0) //нельзя меньше 100 и не кратно 100
            {
                Console.WriteLine("Сумма должна быть не меньше 100 и кратна 100.");
                continue;
            }

            if (x > 150000)
            {
                Console.WriteLine("Сумма не может быть больше 150000 руб."); //нельзя больше 150000
                continue;
            }

            Console.WriteLine("Вам будет выдано 👇");

            int[] denominations = {5000, 2000, 1000, 500, 200, 100 }; //номиналы купюр
            int amount = x; //сохранение исходной суммы в доп переменную

            foreach (int d in denominations) //цикл перербора значения по массиву (d от denominations)
            {
                if (amount >= d) // если исходное больше, то делаем вывод
                {
                    int count = amount / d;
                    Console.WriteLine($"Вам выдано: {count} купюр по {d} руб.");
                    amount %= d; //сохранение остатка в рабочую переменную  
                }
            }
        }
    }
}
