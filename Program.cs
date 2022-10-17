﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using static System.Console;

Clear();
WriteLine("Введите кол-во строк: ");
int lines = int.Parse(ReadLine()!);
WriteLine("Введите кол-во столбцов: ");
int columns = int.Parse(ReadLine()!);
double[,] randomNumbers = new double[lines, columns];
GetArrayRandomNumbers(randomNumbers);
PrintArray(randomNumbers);

void GetArrayRandomNumbers(double[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] parameter) {
    for(int i = 0; i < parameter.GetLength(0); i++) {
        Write("[");
        for(int j = 0; j < parameter.GetLength(1); j++) {
            Write(parameter[i,j] + " ");
        }
        Write("]");
        WriteLine("");  
    }
}


