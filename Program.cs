/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write8(count + " ");
    }
}
/*адача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.WriteLine(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Write("Введите число M: ");
int mak = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int nak = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(mak,nak);


// вызов функции Аккермана
void AkkermanFunction(int mak, int nak)
{
    Console.Write(Akkerman(mak, nak)); 
}

// функция Аккермана
int Akkerman(int mak, int nak)
{
    if (mak == 0)
    {
        return nak + 1;
    }
    else if (nak == 0 && mak > 0)
    {
        return Akkerman(mak - 1, 1);
    }
    else
    {
        return (Akkerman(mak - 1, Akkerman(mak, nak - 1)));
    }
}

