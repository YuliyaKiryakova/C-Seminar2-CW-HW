/* Прога, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
*/

Console.WriteLine("Введите цифру: ");
int number = int.Parse(Console.ReadLine()!);

bool Workdays(int num)
{
    if (num >= 1 && num <= 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня недели нет");
    return false;
}

if (Workdays(number))
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Работаем...");
    }
}

/* идеальное решение
*/

// Console.WriteLine("Введите цифру: ");
// int number = int.Parse(Console.ReadLine()!);

// bool InvalidWeekDay(int num)
// {
//     if (num > 0 && num <= 7)
//     {
//         return true;
//     }
//     Console.WriteLine("Нет такого дня недели");
//     return false;
// }

// bool Weekend(int weekend)
// {
//     if (weekend > 5)
//     {
//         return true;
//     }
//     return false;
// }

// if (InvalidWeekDay(number))
// {
//     if (Weekend(number))
//     {
//         Console.WriteLine("Выходной!");
//     }
//     else
//     {
//         Console.WriteLine("Работаем...");
//     }
// }
