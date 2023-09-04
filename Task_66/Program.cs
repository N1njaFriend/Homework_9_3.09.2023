// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {num1} до {num2}: {PrintGetSum(num1, num2)}");
}
else
{
    System.Console.WriteLine("Введите число N больше M");
}

int PrintGetSum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + PrintGetSum(start + 1, end);
}