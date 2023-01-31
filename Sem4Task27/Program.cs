// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int ReadData(string msg) //Метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, int msg2) //Выводим результат пользователю
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSym(int num) //вводим число, которое нужно подсчитать
{
    int res =0; 
    while(num>0) //пока больше нуля
    {
        res=res+num%10; //суммируем с с остатком отделения на 10
        num=num/10; // уменьшаем заданное число на один порядок
    }
    return res; //возвращаем результат
}

int number = ReadData("Введите число: ");
int res = SumSym(number);
PrintData("Результат: ",res);


// //2 варинт решения задачки

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Введите число: ");
//         int number = int.Parse(Console.ReadLine()?? "0");
//         int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         Console.WriteLine("Итого: " + sum);
//     }
// }
