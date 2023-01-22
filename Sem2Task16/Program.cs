// Задача № 16. Напишите программу, 
// которая принимает на вход 2 числа и проверяет ли одно квадратом другого.


// Console.Write("Введите числа:"); // Вводим данные с консоли
// int num1 = int.Parse(Console.ReadLine()??"0"); // Ввод первого числа
// int num2 = int.Parse(Console.ReadLine()??"0"); // Ввод второго числа
// int result = num1*num1;
// if(result==num2)
// {
//     Console.WriteLine("Является квадратом");
// }
// else
// {
// Console.WriteLine("Не является квадратом "+result);
// }


// Вариант решения 2.1
// Console.Write("Введите числа:"); // Вводим данные с консоли
// int num1 = int.Parse(Console.ReadLine()??"0"); // Ввод первого числа
// int num2 = int.Parse(Console.ReadLine()??"0"); // Ввод второго числа
// if(num1*num1 == num2)
//{
//Console.WriteLine("Первое число квадрат второго");
//}
// ifelse(num2*num2 == num1)
//{
//Console.WriteLine("Второе число квадрат первого");
//}
// else
//{
    // Console.WriteLine("Не квадрат");
//}

//Второй варинт решения
Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1,num2); //TestSQRT - это тест на квадратность, проверяем является 1ое квадратом второго и наоборот
TestSQRT(num2,num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i); //вывод согласия
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i); // вывод несогласия
    }
}
