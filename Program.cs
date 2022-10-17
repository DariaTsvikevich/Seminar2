/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100,1000);

int result = CutNumber(num);
Console.WriteLine($"New version of number {num} is {result}");
*/
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNum(int randnum)
{
    int max = 0;
    int ed = randnum % 10;
    int des = randnum / 10;
    if (ed > des)
    {
        max = ed; 
    }
    else 
    {
        max = des;
    }
    return max;
}

int number = new Random().Next(10,100);
int result = MaxNum(number);
Console.WriteLine($"Max number of number {number} is {result}");
*/
/*
bool Multiplicity (int firstNum, int secondNum)
{
    if (secondNum % firstNum == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input first ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second ");
int second = Convert.ToInt32(Console.ReadLine());

bool res = Multiplicity (first,second);
Console.WriteLine (res);
*/
/*
bool Square (int first, int second)
{
    if (first == second * second || second == first * first)
    {
        return true;
    }
    else
    {
       return false;    
    }
}
Console.WriteLine("Input first ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second ");
int second = Convert.ToInt32(Console.ReadLine());

bool res = Square (first,second);
Console.WriteLine (res);
*/