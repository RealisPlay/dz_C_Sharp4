/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int count = 1;
void PrintNumber(int N, int count)
{
    if (count > N) return;
    PrintNumber(N, count + 1);
    Console.Write(count + ", ");
}

int N = SetNumber("N");
PrintNumber(N, count);

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumMN(int M, int N)
{
    int num = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        num = M + SumMN(M, N);
        return num;
    }
}

void GetSum(int N, int M)
{
    Console.Write($"Сумма элементов от M до N = {SumMN(M - 1, N)}");
}

int M = SetNumber("M");
int N = SetNumber("N");
GetSum(N, M);

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetAkkerman (int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return GetAkkerman(M - 1, 1);
    }
    else
    {
        return (GetAkkerman(M - 1, GetAkkerman(M, N - 1)));
    }
}

int M = SetNumber("M");
int N = SetNumber("N");
Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {GetAkkerman(M, N)}");
