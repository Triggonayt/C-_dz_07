﻿
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("enter the number of rows");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("number of columns");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// ArrayRandom(numbers);
// PrintArray(numbers);

// void ArrayRandom(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.Clear();
// int line = 5;
// int columnsVol = 5;
// int [,] numbers = new int [line,columnsVol];
// ArrayRandom(numbers);
// PrintArray(numbers);

// void ArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
//         }
//     }
// }

// void PrintArray(int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Console.WriteLine("line numbers ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("column number");
// int m = Convert.ToInt32(Console.ReadLine());

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("There is no such element");
// }
// else
// {
//     Console.WriteLine($"element is equal to {n} and {m} = {numbers[n-1,m-1]}");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void ArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
//         }
//     }
// }
// void PrintArray(int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Console.Clear();
// int line = 5;
// int columnsVol = 5;
// int [,] numbers = new int [line,columnsVol];
// ArrayRandom(numbers);
// PrintArray(numbers);

// for(int j = 0; j < numbers.GetLength(0); j++ )
// {
//     double avarage = 0;
//     for(int i = 0; i < numbers.GetLength(1); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / line;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
