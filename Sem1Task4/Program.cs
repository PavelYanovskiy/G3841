// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


string? inputNum1 = Console.ReadLine(); // Считываем данные с консоли 1 число
string? inputNum2 = Console.ReadLine(); // Считываем данные с консоли 2 число
string? inputNum3 = Console.ReadLine(); // Считываем данные с консоли 3 число

if(inputNum1!=null && inputNum2!=null && inputNum3!=null) //Проверяем чтобы данные не были пустыми
{
     
    int number1 = int.Parse(inputNum1); //Парсим 1 введенное число
    int number2 = int.Parse(inputNum2); //Парсим 2 введенное число
    int number3 = int.Parse(inputNum3); //Парсим 3 введенное число

       if(number1 > number2)  // проверяем какое число является большим
    {
        if(number1 > number3) // проверяем какое число является большим
        {
           Console.WriteLine("№1 это максимальное число");  //Выводим данные в консоль
        }
        else
        {
            Console.WriteLine("№3 это максимальное число"); //Выводим данные в консоль
        }
    }
    else
    {
     if(number2 > number3) // проверяем какое число является большим из оставшихся
     {
          Console.WriteLine("№2 это максимальное число"); //Выводим данные в консоль
     }
     else
     {
          Console.WriteLine("№3 это максимальное число"); //Выводим данные в консоль
     }  
        
    }
}
