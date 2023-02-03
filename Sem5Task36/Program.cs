//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumPos(int[] arr) //накапливаем элеиенты на нечетных позициях и выдаем их сумму
{
    int res = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        res+=arr[i];      
    }
    return res;
}

void PrintData(string res) //Выводим результат пользователю
{
    Console.WriteLine(res);
}
int[] testArr = Gen1DArray(101,1,999); //сначала генерируем массив, указываем границы и длину массива
Print1DArr(testArr); // печатаем массив
int Sum = SumPos(testArr); //считаем сумму нечетных элементов
PrintData("Сумма чисел на нечетных позициях: "+Sum);