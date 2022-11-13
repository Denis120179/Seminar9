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















// нахождение факториала через рекурсию
/*
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n-1);
}
*/

// Вывести все натуральные числа в промежутке от 1 до N
/*
Console.WriteLine("ВВедите число N:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start+1, end));
}
*/

// Задача 
// задать значение m и n, вывести все натуральные числа в этом промежутке
/*
Console.WriteLine("ВВедите число M:  ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите число N:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start+1, end));
}
*/

// Задача
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
Console.WriteLine("Введите число:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(N));

int SumNumbers(int number)
{
    if (number < 1) return number;
    return number % 10 + SumNumbers(number/10);
}
*/

// Задача
// Напишите программу, которая на вход принимает два числа А и В и возводит число А в степень В
/*
Console.WriteLine("Введите число A:  ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:  ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(Degry(A, B));

int Degry(int a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    return a*Degry(a, b-1);
}
*/
