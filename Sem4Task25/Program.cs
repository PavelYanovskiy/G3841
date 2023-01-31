// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int ReadData(string msg) //метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, double msg2) //выводим результат пользователю
{
Console.WriteLine(msg1);
Console.WriteLine(msg2);
}

 
double degree(int numA, int numB) //Метод возведения числа А в степень B
{
    double res = Math.Pow(numA, numB);
    return res;
}
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
double res = degree(numA, numB); //Обращаемся к методу, передаем результат в переменную res
PrintData("Число А в степени B: ", res); //вывод результата


// //Вариант 2
// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numberA, numberB);
// Console.WriteLine("Ответ: " + exponentiation);
