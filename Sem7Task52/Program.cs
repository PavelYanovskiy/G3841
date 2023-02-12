// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


int[,] FillTwoDimArray(int countString, int countColumn) //заполняем двумерный массив
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
void PrintTwoDimArray(int[,] resArray) //печатаем двумерный массив
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
double[] MeanColumn(int[,] resArray) //считаем среднее арифметическое число каждого столбца
{
    double[] meanArr = new double[resArray.GetLength(1)]; //используем double так как число может быть вещественным
    for (int i = 0; i < resArray.GetLength(1); i++) //сначала проходим по столбцам - это GetLenght(1)
    {
        for (int j = 0; j < resArray.GetLength(0); j++) //сразу проходимся по строкам - это GetLength(0)
        {
            meanArr[i] = meanArr[i] + resArray[j, i]; //сумму столбца двумерного массива накапливаем в одномерный
        }
        meanArr[i] = meanArr[i] / resArray.GetLength(0); 
    }
    return meanArr;
}


void Print1DArray (double[] meanArr) //выводим массив на печать
{
    for (int i = 0; i < meanArr.Length; i++)
    {
        Console.Write(meanArr[i] + "\t");
    }
}

int countString = InputNum("Введите количество строк: "); //просим пользователя ввести данные
int countColumn = InputNum("Введите количество столбцов: ");
int[,] resArray = FillTwoDimArray(countString, countColumn);
PrintTwoDimArray(resArray);
Console.WriteLine();
double[] meanArr = MeanColumn(resArray);
Print1DArray(meanArr);