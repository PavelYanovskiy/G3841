// Задача 8: Напишите программу, 
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

string? inputNum = Console.ReadLine(); // Считываем данные с консоли
if(inputNum!=null)
{
    int inputNumber1 = int.Parse(inputNum); // парсим введеное число
    string Result = string.Empty;
    for(int i = 2; i < inputNumber1; i = i + 2)
    {
        Result = Result + i + ","; //
    }
    if(inputNumber1%2 == 0)
    {
        Result = Result + inputNumber1;
    }
    Console.WriteLine(Result); //Выводим данные в консоль
}

