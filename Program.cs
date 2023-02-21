// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

double[,] doubleNumbers = new double[rows, columns];

GetDoubleMatrix(doubleNumbers);

PrintDouble(doubleNumbers);

void GetDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[i, l] = new Random().Next(-100, 100) / 10.0;
        }
    }

}

void PrintDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}
Console.WriteLine();

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int i = ReadInt("Введите индекс строки:  ");
int l = ReadInt("Введите индекс столбца:  ");

Console.WriteLine();
int[,] numbers = new int[rows, columns];

CreatArray(numbers);

Print(numbers);

void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            array[i, l] = new Random().Next(1, 100);
        }
    }

}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            System.Console.Write(array[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

if (i < numbers.GetLength(0) && l < numbers.GetLength(1))

{
    Console.Write($"число {numbers[i, l]}");
}

else

{
    Console.WriteLine($"такого элемента нет");
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine();

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

Console.WriteLine();

CreatArray(numbers);

Print(numbers);

Average(numbers);

void Average(int[,] numbers)

{

    for (int l = 0; l < numbers.GetLength(1); l++)

    {
        double result = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)

        {
            result += numbers[i, l];
        }
        Console.WriteLine();
        Console.Write($"Среднее арифметическое ");
        Console.Write($"{Math.Round(result / numbers.GetLength(0), 1)}" + " ");
    }
    Console.WriteLine();
}


// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine();
int n = 4;
int[,] spiralMatrix = new int[n, n];

int value = 1;
int a = 0;
int b = 0;

while (value <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[a, b] = value;
    value++;
    if (a <= b + 1 && a + b < spiralMatrix.GetLength(1) - 1)
        b++;
    else if (a < b && a + b >= spiralMatrix.GetLength(0) - 1)
        a++;
    else if (a >= b && a + b > spiralMatrix.GetLength(1) - 1)
        b--;
    else
        a--;
}

SpiralArray(spiralMatrix);

void SpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}