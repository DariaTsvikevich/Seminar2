//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowRange (int quart)
{
    if (quart ==1)
        Console.WriteLine("x > 0 and y > 0");
    else if (quart ==2)
        Console.WriteLine("x < 0 and y > 0");
    else if (quart ==3)
        Console.WriteLine("x < 0 and y < 0");
    else if (quart ==4)
        Console.WriteLine("x > 0 and y < 0");
    else
        Console.WriteLine("Wrong number!");
}
Console.Write("Input a number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());
ShowRange (quartNum);
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Quarter (int x, int y)
{
    int quart = 0;
    if (x > 0 && y > 0)
        quart = 1;
    else if (x < 0 && y > 0)
        quart = 2;
    else if (x < 0 && y < 0)
        quart = 3;
    else if (x > 0 && y < 0)
        quart = 4;
    else if (x == 0 || y == 0)
        Console.WriteLine("Wrong number!");
    return quart;
}
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quart = Quarter(x,y);
Console.WriteLine($"Your dot is on the quart {quart}.");
*/
    
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance (double x1 , double x2, double y1, double y2)
{
    double gip = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2);
    gip = Math.Sqrt(gip);
    return gip;
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double dist = Distance(x1, x2, y1, y2);
Console.WriteLine($"The distance between two dots is {dist}.");
*/

//Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void Square(int N)
{
    int i = 1;
    while (i <= N)
    {
        int result = i * i;
        Console.Write(result + " ");
        i++;
    }
}
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
Square(N);
*/
