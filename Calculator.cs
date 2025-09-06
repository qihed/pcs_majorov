using System;

class Calculator
{
    static double memory = 0;

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Введите свой пример через пробелы (или exit):");
            string? s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Пустой ввод. Попробуйте ещё раз.");
                continue;
            }
            if (string.Equals(s, "exit", StringComparison.OrdinalIgnoreCase)) break;


            int i1 = s.IndexOf(' ');
            int i2 = s.IndexOf(' ', i1 + 1);
            int i3 = s.Length;

            long n1 = Convert.ToInt64(s[0..i1]);
            string n2 = s[(i1 + 1)..(i2 < 0 ? i3 : i2)];

            long n3 = 0;
            if (i2 >= 0 && i2 < i3) 
                n3 = Convert.ToInt64(s[(i2 + 1)..i3]);

            if (i2 == i3 || i2 < 0)
            {
                if (n2 == "sqrt")
                {
                    if (n1 >= 0)
                    {
                        long root = Convert.ToInt64(Math.Sqrt(Convert.ToDouble(n1)));
                        Console.WriteLine(root);
                    }
                    else
                    {
                        Console.WriteLine("Из отрицательного не вытащишь ты корень!");
                    }
                }
                else if (n2 == "M+")
                {
                    memory += n1;
                    Console.WriteLine($"В памяти теперь: {memory}");
                }
                else if (n2 == "M-")
                {
                    memory -= n1;
                    Console.WriteLine($"В памяти теперь: {memory}");
                }
                else if (n2 == "MR")
                {
                    Console.WriteLine($"Значение из памяти: {memory}");
                }
                else if (n2 == "MC")
                {
                    memory = 0;
                    Console.WriteLine("Память очищена");
                }
                else
                {
                    Console.WriteLine("Запишите пример согласно требованиям");
                }
            }
            else
            {
                if (n2 == "+")
                {
                    Console.WriteLine(n1 + n3);
                }
                else if (n2 == "-")
                {
                    Console.WriteLine(n1 - n3);
                }
                else if (n2 == "*")
                {
                    Console.WriteLine(n1 * n3);
                }
                else if (n1 == 1 && n2 == "/")
                {
                    if (n3 > 0)
                        Console.WriteLine(n1 / n3);
                    else
                        Console.WriteLine("На 0 делить нельзя. Давно пора выучить...");
                }
                else if (n2 == "/")
                {
                    Console.WriteLine(n1 / n3);
                }
                else if (n2 == "%")
                {
                    Console.WriteLine(n1 % n3);
                }
                else if (n2 == "^" || n2 == "**")
                {
                    if (n3 == 2)
                        Console.WriteLine(n1 * n1);
                    else
                    {
                        long degree = Convert.ToInt64(Math.Pow(Convert.ToDouble(n1), n3));
                        Console.WriteLine(degree);
                    }
                }
                else
                {
                    Console.WriteLine("Запишите пример согласно требованиям");
                }
            }
        }
    }
}
