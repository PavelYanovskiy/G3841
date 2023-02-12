// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//указываем количество цветов и какие использовать
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


int n = InputNum("Количество строк матрицы: "); //1) Получение данных от пользователя
int m = InputNum("Количество столбцов матрицы: ");


double[,] matix = FillTwoDimArray(n,m); //2) Генерация двумерного массива


PrintTwoDimArray(matix); //3) Печатаем двумерный массив

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] FillTwoDimArray(int countRow, int countColumn) // метод для заполнения двумерного массива
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(-100, 101)+Math.Round(numberSyntezator.NextDouble(),2);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(double[,] inputArray) //метод для печати двумерного массива
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16)); //разукрашиваем массив
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        Console.WriteLine();
        i++;
    }
}