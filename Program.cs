//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] Create2dArray(int row , int column)
// {
// double[,] array = new double[row,column];

// for(int i = 0; i < row; i++)
// for(int j = 0; j< column; j++)
// array[i,j] = new Random().Next(0,100) + Math.Round(new Random().NextDouble(), 2);

// return array;
// }
// void Write2dArray(double[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j< array.GetLength(1); j++)
// Console.Write($"{array[i,j]} ");
// Console.WriteLine();
// }

// }
// Console.Write("Введите кол-во строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов");
// int column = Convert.ToInt32(Console.ReadLine());
// double[,] array = Create2dArray(row,column);
// Write2dArray(array);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// int[,] Create2dArray()
// {
// int[,] array = new int[5,3];

// for(int i = 0; i < array.GetLength(0); i++)
// for(int j = 0; j< array.GetLength(1); j++)
// array[i,j] = new Random().Next(0,100 + 1);

// return array;
// }
// void Write2dArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j< array.GetLength(1); j++)
// Console.Write($"{array[i,j]} ");
// Console.WriteLine();
// }

// }
// void GetValueArray(int[,] array, int index_row , int index_column)
// {
// if(array.GetLength(0) < index_row || array.GetLength(1) < index_column)
// Console.Write("Числа с такими индексами нет");
// else Console.Write($"Значение массива с индексами [{index_row},{index_column}] : {array[index_row - 1,index_column - 1]}");
// }
// int[,] array = Create2dArray();
// Write2dArray(array);
// Console.Write("Введите индекс строки массива: ");
// int index_row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца массива: ");
// int index_column = Convert.ToInt32(Console.ReadLine());
// GetValueArray(array, index_row , index_column);