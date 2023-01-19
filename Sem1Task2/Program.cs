// Задача 2 Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

//Проверяем чтобы данные не были пустыми
if(inputNum1!=null && inputNum2!=null)
{
     //Парсим введенное число
    int number1 = int.Parse(inputNum1);
        // //Парсим введенное число
    int number2 = int.Parse(inputNum2);

    // проверяем является ли первое число больше второго
    if(number1 > number2)
    {
        Console.WriteLine("Первое число больше второго!");
    }
    else
    {
       Console.WriteLine("Второе число больше первого!"); 
    }
}