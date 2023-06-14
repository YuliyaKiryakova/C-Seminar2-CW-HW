/* Напишите прогу, в которую на вход два числа и выдает кратно одно другому, и если нет, то выдает остаток
1 вариант*/

// Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);
// int result = 0;

// int FindResult (int number1, int number2)
// {
//     result = number1 % number2;
//     return result;
// }

// int res = FindResult(number1, number2);
// if (res==0)
// Console. WriteLine("Первое число кратно второму");
// else
// Console.WriteLine($"Первое число не кратно второму. Остаток {res}");

/* Напишите прогу, в которую на вход два числа и выдает кратно одно другому, и если нет, то выдает остаток
2 вариант*/

int Numbers(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int number1 = Numbers("Введите первое число: ");
int number2 = Numbers("Введите второе число: ");

void Division(int num1, int num2)
{
    int two = num1 % num2;
    if (two == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Некратно, " + two);
    }
}
Division(number1, number2);