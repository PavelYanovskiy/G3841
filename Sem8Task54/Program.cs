// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sort2DArray(int[,] matr) //метод принимает на вход массив
{
    int[] bufArr = new int[matr.GetLength(1)]; //буферный массив
    for (int i = 0; i < matr.GetLength(0); i++) //первым циклом проходим по строчкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) //проходим по столбцам
        {
            bufArr[j] = matr[i, j]; //весь массив кладем в одномерный массив
        }
        Array.Sort(bufArr); //метод сортирвки 
        Array.Reverse(bufArr);
        for (int j = 0; j < matr.GetLength(1); j++) //проходим по отсортированному массиву повторно
        {
            matr[i, j] = bufArr[j]; //отсортированный массив клаедм обратно
        }

    }
}
int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);
Sort2DArray(matrix);
Console.WriteLine();
Print2DArray(matrix);