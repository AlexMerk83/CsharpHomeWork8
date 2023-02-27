using ConsoleIO;
using MyArrays;

main();

void main()
{
    bool isWork = true;

    while (isWork)
    {
        ConsoleIOHandler.PrintMainMenu();

        int taskNo = ConsoleIOHandler.ReadInt("a task number", 0, 5, ConsoleIOHandler.msgNoSuchOption);

        switch (taskNo)
        {
            case 1: Task54MatrixRowsSort(); break;
            case 2: Task56RowOfMatrixWithMinSum(); break;
            case 3: Task58MatrixMultiplication(); break;
            case 4: Task60Print3DArrayWithUniqueNumbers(); break;
            case 5: Task62MatrixSpiralFill(); break;
            case 0: isWork = false; break;
            default: System.Console.WriteLine(ConsoleIOHandler.msgNoSuchOption); break;
        }

        if (isWork)
            ConsoleIOHandler.WaitForAnyKey();
    }
}

#region Task54 Matrix Rows Sort
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void Task54MatrixRowsSort()
{
    Console.Clear();

    int[,] matrix = ArrayHandler.GetRandomMatrix(ConsoleIOHandler.ReadInt("number of rows"),
                                                    ConsoleIOHandler.ReadInt("number of columns"),
                                                        0, 9);
                                            
    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix));
    System.Console.WriteLine();

    ArrayHandler.SortMatrixRows(matrix, false);

    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix));
}
#endregion

#region Task56 Row Of Matrix With Min Sum
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Task56RowOfMatrixWithMinSum()
{
    Console.Clear();

    int[,] matrix = ArrayHandler.GetRandomMatrix(ConsoleIOHandler.ReadInt("number of rows"),
                                                    ConsoleIOHandler.ReadInt("number of columns"),
                                                        0, 9);
                                            
    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix));
    System.Console.WriteLine();
    
    int minSumRow = ArrayHandler.GetMinAndMaxElementsPositions(ArrayHandler.SumMatrixRows(matrix))[0];
    
    System.Console.WriteLine($"Number of the row with the minimum sum of elements is {minSumRow+1}");

    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix, row: minSumRow));

}
#endregion

#region Task58 Matrix Multiplication
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void Task58MatrixMultiplication()
{
    Console.Clear();
    
    System.Console.WriteLine("Enter the dimensions of the first matrix");
    int matrix1RowNum = ConsoleIOHandler.ReadInt("number of rows");
    int matrix1ColNum = ConsoleIOHandler.ReadInt("number of columns");
    int matrix2RowNum = ConsoleIOHandler.ReadInt("number of rows");
    int matrix2ColNum = ConsoleIOHandler.ReadInt("number of columns");

    if (matrix1ColNum != matrix2RowNum)
    {
        System.Console.WriteLine("These matrices cannot be multiplied.");
        System.Console.WriteLine("Two matrices can be multiplied if the number of columns in the first matrix is equal to the number of rows in the second matrix.");
        return;
    }

    int[,] matrix1 = ArrayHandler.GetRandomMatrix(matrix1RowNum, matrix1ColNum, 0, 9);
    int[,] matrix2 = ArrayHandler.GetRandomMatrix(matrix2RowNum, matrix2ColNum, 0, 9);
    
    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix1));
    System.Console.WriteLine(ArrayHandler.MatrixToString(matrix2));
    System.Console.WriteLine(ArrayHandler.MatrixToString(ArrayHandler.MultiplyMatrices(matrix1, matrix2)));

}
#endregion


#region Task60 Print 3D Array With Unique Numbers
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void Task60Print3DArrayWithUniqueNumbers()
{
    Console.Clear();

    int numOfDigits = 2;

    System.Console.WriteLine($"Enter the dimensions of a 3D array to be filled wtih unique random {numOfDigits}-digit integer numbers");

    int dim1 = ConsoleIOHandler.ReadInt("dimension 1", 1, 100);
    int dim2 = ConsoleIOHandler.ReadInt("dimension 2", 1, 100);
    int dim3 = ConsoleIOHandler.ReadInt("dimension 3", 1, 100);

    if (dim1 * dim2 * dim3 > 9 * Math.Pow(10, numOfDigits - 1))
    {
        System.Console.WriteLine("The number of elements of the array exceeds the number of possible unique values.");
        System.Console.WriteLine("The array cannot be created.");
        return;
    }

    Random rnd = new Random();

    int[,,] array3d = new int [dim1, dim2, dim3];
    int filledCount = 0;

    for (int i = 0; i < array3d.GetLength(0); i++)
        for (int j = 0; j < array3d.GetLength(1); j++)
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = rnd.Next((int)Math.Pow(10, numOfDigits - 1), (int)Math.Pow(10, numOfDigits));
                
                while (filledCount > 0 && FindNum(array3d, filledCount, array3d[i, j, k]))
                    array3d[i, j, k] = rnd.Next((int)Math.Pow(10, numOfDigits - 1), (int)Math.Pow(10, numOfDigits));

                filledCount++;
            }

    System.Console.WriteLine(ArrayHandler.array3dToString(array3d));
}

bool FindNum(int[,,] array3d, int searchLmit, int numToFind)
{
    int i = 0,
        j = 0,
        k = 0,
        checkedCount = 0;

    for (i = 0; i < array3d.GetLength(0); i++)
        for (j = 0; j < array3d.GetLength(1); j++)
            for (k = 0; k < array3d.GetLength(2) && checkedCount < searchLmit; k++)
                if (array3d[i, j, k] == numToFind)
                    return true;
                else
                    checkedCount++;

    return false;
}

#endregion

#region Task62 Matrix Spiral Fill
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Task62MatrixSpiralFill()
{
    Console.Clear();

}
#endregion