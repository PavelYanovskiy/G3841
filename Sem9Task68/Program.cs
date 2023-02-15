// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(int prefix)
{
    Console.Write(prefix);
}
int Ackermann(int m, int n) //метод вычисления функции Аккермана
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));

}

int m = ReadData("Введите значение числа M:");
int n = ReadData("Введите значение числа N:");
int a = Ackermann(m, n);
Console.Write("Результат: ");
PrintResult(a);
Console.WriteLine();

