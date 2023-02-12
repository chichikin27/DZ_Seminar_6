//Показать двумерный массив размером m×n заполненный вещественными числами
//Задать двумерный массив следующим правилом: Aₘₙ = m+n
//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
//Написать программу, которая обменивает элементы первой строки и последней строки


//Показать двумерный массив размером m×n заполненный вещественными числами
/*
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = new double [m, n];

Random rand = new Random();

Console.WriteLine("===============================");
for( int i = 0; i < matrix.GetLength(0); i++)
{
    for( int j = 0; j < matrix.GetLength(1);j++)
    {
        matrix[i, j] = rand.Next(-990, 990)/10.0;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

//Задать двумерный массив следующим правилом: Aₘₙ = m+n
/*
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m,n];

Console.WriteLine("===============================");

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("===============================");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}


//Написать программу, которая обменивает элементы первой строки и последней строки
/*
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];


for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console. WriteLine();
}
Console.WriteLine("===============================");

int x = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    x = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = matrix[0, i];
    matrix[0, i] = x;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/