﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int[,,] arr = { //объявлям массив 
                   {
                       { 1, 2, 3, 4 },
                       { 5, 6, 7, 8 },
                       { 9, 10, 11, 12 }
                   },
                   {
                       { 13, 14, 15, 16 },
                       { 17, 18, 19, 20 },
                       { 21, 22, 23, 24 }
                   }
              };


void Print3DArr(int[,,] arr) // Печатаем трехмерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
            }
        }
        Console.WriteLine("");
    }
}
Print3DArr(arr);


