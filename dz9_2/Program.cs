/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
void GetSumOfDigit(int userNumberM, int userNumberN, int sum)
{
    if (userNumberM > userNumberN)
    {
        Console.WriteLine($"Сумма чисел от М до N = {sum}");
        return;
    }
    sum += (userNumberM++);
    GetSumOfDigit(userNumberM, userNumberN, sum);
}
int userNumberM = GetUserInt("Введите число М: ");
int userNumberN = GetUserInt("Введите число N: ");
GetSumOfDigit(userNumberM, userNumberN, 0);