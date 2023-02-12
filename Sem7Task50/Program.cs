//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.



int InputNum(string msg) //метод принимает данные
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


int[,] FillTwoDimArray(int countString, int countColumn) //метод генерации массива
{
       int[,] resArray = new int[countString, countColumn];
    for (int i = 0; i < countString; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            resArray[i, j] = new Random().Next(0, 10);
        }
    }
    return resArray;
}

void PrintTwoDimArray(int[,] resArray) //этим методом печатаем двумерный массив
{
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            Console.Write(resArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SerchElements(int[,] arr, int line, int colum) //этим методом ищем нужный индекс по введенным данным
{
    if (line < arr.GetLength(0))
    {
        if (colum < arr.GetLength(1))
        {
            int res = arr[line, colum];
            Console.WriteLine("Искомый индекс " + line + colum + " равен значению " + res);
        }
    }
    else
    {
        Console.WriteLine("Искомый индекс " + line + colum + " в массиве отсутсвует");
    }
}

int countString = InputNum("Введите количество строк: ");
int countColumn = InputNum("Введите количество столбцов: ");
int line = InputNum("Введите индекс строки: ");
int colum = InputNum("Введите индекс столбца: ");
int[,] resArray = FillTwoDimArray(countString, countColumn);
PrintTwoDimArray(resArray);
SerchElements(resArray, line, colum);