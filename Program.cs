// Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
/*
Console.WriteLine("ВВедите число N:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}
*/

// Задача 66
// Задайте значения M и N. 
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N
/*
Console.WriteLine("Введите число M:  ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Summa(M, N));

int Summa(int A, int B)
{
    if (A == B) return B;
    return A + Summa (A + 1, B);
}
*/

// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
/*
Console.WriteLine("Введите число M:  ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(FA(M, N));

int FA(int A, int B)
{
    if (A == 0) return B + 1;
    if (A > 0 && B == 0) return FA(A-1, 1);
    else return FA(A - 1, FA(A, B - 1));
}
*/