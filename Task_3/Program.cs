/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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

// Метод для формирования двумерного массива,
// который является результатом произведения двух 
// двумерных массивов
int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int arrRow1 = array1.GetLength(0);
    int arrCol1 = array1.GetLength(1);
    int arrRow2 = array2.GetLength(0);
    int arrCol2 = array2.GetLength(1);

    // Проверка возможности формирования итогового массива
    if (arrRow1 == arrRow2 && arrCol1 == arrCol2 ||
        arrRow1 == arrCol2 && arrCol1 == arrRow2)
    {
        System.Console.WriteLine("Размеры матриц удовлетворяют требованиям!");
        System.Console.WriteLine("Начат процесс формирования произведения массивов");

        // Блок определения размера двумерного массива с итогами
        int row = 0;
        int col = 0;
        if (arrRow1 < arrRow2) row = arrRow1;
        else row = arrRow2;
        if (arrCol1 < arrCol2) col = arrCol1;
        else col = arrCol2;
        int[,] FatalArray = new int[row, col];

        for (int i = 0; i < arrRow1; i++)
        {
            for (int j = 0; j < arrCol2; j++)
            {
                for (int k = 0; k < arrRow2; k++)
                {
                    FatalArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return FatalArray;
    }
    else
    {
        System.Console.WriteLine("Произведение массивов невозможно");
        int[,] a = new int[1, 1];
        return a;
    }
}


/*****************************************************************************/
//Основной блок программы
System.Console.WriteLine("Программа для нахождения произведения двух матриц");
int[,] array1_Task3 = FillMatrix(3, 3);
System.Console.WriteLine("Первая матрица: ");
PrintMatrix(array1_Task3);

int[,] array2_Task3 = FillMatrix(3, 3);
System.Console.WriteLine("Вторая матрица: ");
PrintMatrix(array2_Task3);

int[,] FinalMultiplivationArr = MultiplicationMatrix(array1_Task3, array2_Task3);
PrintMatrix(FinalMultiplivationArr);

