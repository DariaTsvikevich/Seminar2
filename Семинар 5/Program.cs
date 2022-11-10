//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindNegativeSum (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array [i] < 0)
            sum += array[i];
    return sum;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int negativeSum = FindNegativeSum(myArray);
Console.WriteLine($"Sum of negative elements is " + negativeSum);
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

bool Compare (int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        if (array [i] == num)
            return true;
    return false;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a target number: ");
int target = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

bool result = Compare(myArray, target);
Console.WriteLine(result);
*/

//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int [] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 101);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int Num (int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array [i] >= a && array [i] <= b)
            count++;
    return count;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n);
ShowArray(myArray); 

Console.Write("Input a lowwer limit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input upper limit: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Num(myArray, a, b);
Console.WriteLine(result);
*/

//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
void ShowArrayNegetive(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] * -1 + " ");

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

ShowArrayNegetive(myArray);
*/
