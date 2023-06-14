/* Прога, которая на вход число и проверит, кратно ли оно одновременно 7 и 23
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

string Multiplicity(int number)
{
    string res = "No";
    if (number % 7 == 0 && number % 23 == 0)
    res = "Yes";
    return res;
}

int num = InputNum("Введите целое число: ");
string result = Multiplicity(num);
Console. WriteLine(result);
