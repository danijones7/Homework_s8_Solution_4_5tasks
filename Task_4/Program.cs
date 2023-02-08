/* Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)

27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// Метод для заполнения трехмерного массива
int[,,] FillMatrix(int length, int width, int height)
{
    int[,,] cube = new int[length, width, height];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                cube[i, j, k] = rand.Next(0, 10);
            }
        }
    }
    return cube;
}

// Метод для вывода элементов массива
void PrintMatrix(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                System.Console.Write(cube[i, j, k] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

// Метод для построчного вывода элементов и индексов элементов трехмерного массива
void Print3DMatrixIndex(int[,,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i,j,k] + " (" + i + ", " + j + ", " + k + ")" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

/******************************************************************************************************/
// Основной блок программы
System.Console.WriteLine("Программа для формирования трехмерного массива из случайных чисел от 0 до 9");
// Первый способ заполнения и вывода трехмерного массива
int[,,] Array3D = FillMatrix(2, 2, 2);
PrintMatrix(Array3D);

// РЕШЕНИЕ ПОСТАВЛЕННОЙ ЗАДАЧИ
// Dывод индексов элементов трехмерного массива
Print3DMatrixIndex(Array3D);