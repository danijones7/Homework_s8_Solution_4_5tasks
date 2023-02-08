/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


// Метод для заполнения двумерного массива случайными элементами от 0 до 9
int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

// Метод для вывода элементов массива
void PrintMatrix(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//Метод для поиска строки двумерного массива сумма элементов которой, больше других строк
void RowValue(int[,] matrix)
{
    int sum = 0;
    int[] arr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }

    int temp = 0;
    int count = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k] > temp)
        {
            temp = arr[k];
            count = k + 1;
        }
    }
    System.Console.WriteLine($"Строка в двумерном массиве с наибольшей суммой элементов: {count}");
    System.Console.WriteLine($"Сумма элементов в строке составляет: {temp}");
}


// Основной блок программы
System.Console.WriteLine("Программа для вывода номера строки двумерного массива");
System.Console.WriteLine("сумма элементов которой, больше других строк");
int[,] matrixTask2 = FillMatrix(5, 5);
PrintMatrix(matrixTask2);
RowValue(matrixTask2);