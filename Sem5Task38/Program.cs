// // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int ReadData(string msg) //получаем данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
    }

void PrintData(string res) // выводим результат пользователю
{
    Console.WriteLine(res);
}
int[] Gen1DArr(int len, int minValue, int maxValue) //генерируем массив
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int Search(int[] arr)
{
    int res = 0;
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    res = max - min;
    return res;
}

int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArr(len, minValue, maxValue);
Print1DArr(arr);
int res = Search(arr);
PrintData("Разница между максимальным и минимальным элементом массива: " + res);
