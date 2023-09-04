// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Pow(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (y == 0)
    {
        return Pow(x - 1, 1);
    }
    else
    {
        return Pow(x - 1, Pow(x, y - 1));
    }
}
Console.WriteLine($"Результат функции Аккермана для чисел {M} и {N}: {Pow(M, N)}");