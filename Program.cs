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