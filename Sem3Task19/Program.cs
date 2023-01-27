// Задача № 19. Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.


int ReadData(string msg) //Метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

bool PalinTest(int n)
{
    int digit1 = n / 10000;
    int digit2 = (n / 1000) % 10;
    int digit3 = (n / 10) % 10;
    int digit4 = n % 10;
    bool res = ((digit1 == digit4) && (digit2 == digit3)) ? true : false;
    return res;
}

void PrintData(string res) // вывод результата пользователю
{
    Console.WriteLine(true + res);
}

int num = ReadData("Введите число: ");  //пользователь вводит данные
bool res = PalinTest(num);   //обращение к программе
if (res)   //вывод ответа пользователю
{
    PrintData(" Это число палиндром");
}
else
{
    PrintData(" Это чсло НЕ палиндром");
}







// //2ой варинт решения
// Console.Write("Введите число: "); //просим ввести данные
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3]) //проверяем числа, соотвествуют ли они друг другу
//   {
//     Console.WriteLine("Ваше число - палиндром."); //выводим результат
//   }
//   else Console.WriteLine("Ваше число - НЕ палиндром.");
// }

// if (number!.Length == 5) //проверяем правильность выполнения условия задачи, а именно ввод 5 значного числа
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine("Введите пятизначное число.");

