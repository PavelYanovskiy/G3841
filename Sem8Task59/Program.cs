// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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


(int x, int y) SearchMinElem(int[,] matr) //поиск минимального элемента массива
{
    int raw = 0;
    int col = 0;
    int minElem = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++) //внешний цикл, 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j]) //если элемент больше чем элемент массива то..
            {
                raw = i; //..запомнимаем и строку и колонку
                col = j; //здесь содержать координаты минимального элемента
                minElem = matr[i, j];
            }
        }
    }
    return (raw, col);
}


int[,] Update2DArray(int[,] matr, int x, int y) //вводим матрицу и вводим номер строчки и столбца, которые должны блокировать
{
    int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1]; //сразу созадем матрицу на 1 меньше, 
                                                                            //т.к. сокращает кол-во строк и столбцов

    int k = 0; //водим две переменные которые будут меняться для нашего итератора
    int m = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < matr.GetLength(1); j++) //внешний цикл i j также и проходят по столбцам и строкам
        {
            if (i != x && j != y) ///добавляем условие, что мы можем вносить новые значения в матрицу в том случае 
                                    //если строка и столбец не совпдают с удаляемыми
            {
                resArr[k, m] = matr[i, j];
            }
            if (j != y)
            {
                m++; //внутенние м и к остаются на перещедктваемых строочках
            }
        }
        if (i != x)
        {
            k++;
        }
    }
    return resArr;
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

(int x, int y) minElem = SearchMinElem(matrix);

int[,] newMatrix = Update2DArray(matrix, minElem.x, minElem.y);
Print2DArray(newMatrix);