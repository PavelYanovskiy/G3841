// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//* Ввести с клавиатуры длину массива и диапазон значений элементов


int ReadData(string msg) //Метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenArr(int num, int begin, int end) //генерируем массив, устанавливаем границы массива
{
    Random rnd = new Random(); //делаем генератор 
    int[] arr = new int[num]; //указываем длину массива 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end); //обращаемся к каждому элементу массива через индекс
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите размер массива: ");
int begin = ReadData("Введите цифру начала диапазона: ");
int end = ReadData("Введите цифру конца диапазона: ");
int[] arr = GenArr(arrLen, begin, end);

PrintArr(arr);

