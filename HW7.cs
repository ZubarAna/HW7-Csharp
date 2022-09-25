/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
/*
void InputMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);
*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Ввод:
1
2
Вывод:
4
 */

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(-10, 11);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [5, 5];
InputMatrix(matrix);
PrintMatrix(matrix);


if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение элемента " + n + "-й строки и " + m + "-го столбца равно " + matrix[n-1,m-1]);
}
*/

 /* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(-10, 11);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; \t");
}

Console.WriteLine();

*/



