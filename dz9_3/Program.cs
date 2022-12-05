/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
int result(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return result(m - 1, 1);
    }
    else
    {
        return result(m - 1, result(m, n - 1));
    }
}
int m = GetUserInt("Введите число M: ");
int n = GetUserInt("Введите число N: ");
int Akkerman = result(m, n);
Console.WriteLine($"Функция Аккермана = {Akkerman} ");