using System;

class Calendar
{   
    public static void Run()
    {
        string[] week = { "", "пн", "вс", "ср", "чт", "пт", "сб", "вс" };
        Console.WriteLine("С какого дня начинается неделя: пн, вт, ср, чт, пт, сб, вс?");
        string? dayBegin = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(dayBegin) || Array.IndexOf(week, dayBegin) == -1)
                {
                    Console.WriteLine("Неправильный ввод. Попробуйте ещё раз.");
                    return;
                }
        Console.WriteLine("Какой день хотим проверить?");
        string? dayCheck = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(dayCheck) || Convert.ToInt32(dayCheck) > 31)
                {
                    Console.WriteLine("Неправильный ввод. Попробуйте ещё раз.");
                    return;
                }
        // нужно прописать ограничение по выходным и механику расчета дней
    }
}


