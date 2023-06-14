/* Прога, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

int TwoDigit(int num)
{
    int res = num / 10 % 10;
    return res;
}

int result = TwoDigit(number);
Console.WriteLine($"Получилось число {result}");

// // идеальное решение

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()!;
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Ведите трехзначное число: ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
//     return;
// }

// Console.WriteLine($"Введенное число {number}");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра в числе {secondRank}");
