//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers(double n)
{
    if(n > 1) ShowNumbers(n - 1);
    Console.Write(n + " ");
}
ShowNumbers(10);
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
double SumOFDigits(double num)
{
    if(num != 0) return SumOFDigits(num / 10) + num % 10;
    return 0;
}
Console.WriteLine(SumOFDigits(1234));
*/
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(double m, double n)
{
    if (m > n)
    {
        ShowNumbers(m - 1, n);
        Console.Write(m + " ");
    }
    else
    {
        if (n > m) ShowNumbers(n - 1, m);
        Console.Write(n + " ");
    }
}
ShowNumbers(1, 5);
*/
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double PowNumbers(double a, double b)
{
    if (b > 0)
        return PowNumbers(a, b - 1) * a;
    if (b < 0)
        return PowNumbers(a, b + 1) / a;
    return 1;
}
Console.Write("Input number A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumbers(a, b));
*/