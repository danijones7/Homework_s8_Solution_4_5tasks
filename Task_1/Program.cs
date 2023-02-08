/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

// Метод по упорядочиванию элеметов строк двумерного массива по возрастанию
int[,] Ascending(int[,] matrix)
{
    // Задается одномерный массив для хранения элементов строки двумерного массива
    int[] massive = new int[matrix.GetLength(1)];     

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            massive[j] = matrix[i, j]; // Запись элемента в одномерный массив
        }

        // Блок для упорядочиванию записанных элементов по возрастанию
        int count = 0;
        for (int k = 0; k < massive.Length; k++)
        {
            for (int l = 0; l < massive.Length; l++)
            {
                if (massive[k] > massive[l])
                {
                    count = massive[k];
                    massive[k] = massive[l];
                    massive[l] = count;
                }
            }
        }
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            // Присвоение элементов обратно в двумерный массив
            matrix[i, n] = massive[n];
        }
    }
    System.Console.WriteLine();
    return matrix;
}


// Основной блок программы
System.Console.WriteLine("Программа для упорядочивания элементов в строках двумерного массива по убыванию");
int[,] matrixMassive = FillMatrix(4, 3);
PrintMatrix(matrixMassive);

// Выозов функции по упорядочиванию элементов строк двумерного массива
matrixMassive = Ascending(matrixMassive);

PrintMatrix(matrixMassive);