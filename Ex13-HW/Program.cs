/* Прога, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

int ThirdDigitLeft(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine($"Третья цифра {ThirdDigitLeft(number)}");



/*идеальное решение
*/

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = int.Parse(Console.ReadLine()!);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число: ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }
