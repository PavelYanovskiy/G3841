// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печатаем результат
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int RecSumMN(int m, int n)
{
    if (m >= n) return n; // точка остановки происходит когда минимальное число будет равно максимальномоу
    return m + RecSumMN(m + 1, n); //вызываем метод RecSumMN и прибавляем к минимальному значению 1
}


int m = ReadData("Введите значение числа M:");
int n = ReadData("Введите значение числа N:");
int res = m < n ? RecSumMN(m, n): RecSumMN(n, m);
PrintResult(res);