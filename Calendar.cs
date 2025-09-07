using System;

class Calendar
{
    public static void Run()
    {
        string[] week = { "", "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
        string[] weekend = { "1", "2", "3", "4", "5", "8", "9", "10" };

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
        switch (dayBegin)
        {
            case "пн":
                switch (dayCheck)
                {
                    case "6":
                    case "7":
                    case "13":
                    case "14":
                    case "20":
                    case "21":
                    case "27":
                    case "28":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            case "вт":
                switch (dayCheck)
                {
                    case "6":
                    case "5":
                    case "13":
                    case "12":
                    case "20":
                    case "19":
                    case "27":
                    case "26":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            case "ср":
                switch (dayCheck)
                {
                    case "4":
                    case "5":
                    case "11":
                    case "12":
                    case "18":
                    case "19":
                    case "25":
                    case "26":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            case "чт":
                switch (dayCheck)
                {
                    case "4":
                    case "3":
                    case "11":
                    case "10":
                    case "18":
                    case "17":
                    case "25":
                    case "24":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            case "пт":
                switch (dayCheck)
                {
                    case "2":
                    case "3":
                    case "9":
                    case "10":
                    case "16":
                    case "17":
                    case "23":
                    case "24":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;
            case "сб":
                switch (dayCheck)
                {
                    case "2":
                    case "1":
                    case "9":
                    case "8":
                    case "16":
                    case "15":
                    case "23":
                    case "22":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            case "вс":
                switch (dayCheck)
                {
                    case "1":
                    case "7":
                    case "8":
                    case "14":
                    case "15":
                    case "21":
                    case "22":
                        Console.WriteLine("Выходной!");
                        break;

                    default:
                    if (Array.IndexOf(weekend, dayCheck) != -1) Console.WriteLine("Выходной!");
                    else
                    {
                        Console.WriteLine("Рабочий(");
                    }
                        break;
                }
                break;

            default:
                break;
        }
    }
}


