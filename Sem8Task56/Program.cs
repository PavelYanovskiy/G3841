// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinSummRaw(int[,] matr) //метод подсчета минимальной суммы
{
    int[] sumArrLine = new int[matr.GetLength(0)];
    int buf = 0;
    for (int i = 0; i < matr.GetLength(0); i++) //проходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) //проходим по столбцам
        {
           buf += matr[i,j];
           sumArrLine[i] = buf;
        }
        buf = 0;
    }
    int min = sumArrLine[0];
    int minLine = 0;
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        if (min > sumArrLine[i])
        {
            min = sumArrLine[i];
            minLine = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minLine + " строка");
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);
MinSummRaw(matrix);