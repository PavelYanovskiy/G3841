// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Gen1DArray(int len, int minValue, int maxValue) //генерируем массив, устанавливаем границы массива
{
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

int CountElements(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n%2==0);
}

void PrintData(string res) //Выводим результат пользователю
{
    Console.WriteLine(res);
}

int[] testArr = Gen1DArray(101,100,999); //сначала генерируем массив, указываем границы и длину массива
Print1DArr(testArr);// печатаем массив
int count = CountElements(testArr); //считаем сумму четных чисел в массиве
PrintData("Количество четных чисел в массиве от 100 до 999: "+count);