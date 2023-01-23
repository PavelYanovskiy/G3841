//  Задача №13 Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 1 Вариант решения задачи
// Console.Write("Введите число: ");
// char[] digit = (Console.ReadLine() ?? "0").ToCharArray(); //создаем массив и присваиваем ему им и проверяем на нуль
// if(digit.Length >= 3) //проверяем длину массива
// {
//     Console.WriteLine(digit[2]); // вызываем второй элемент массива
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет"); // показываем сообщение, если число двухзначное
// }


// 2ой вариант решения задачи
Console.Write("Введите число:"); //просим ввести число
int num = int.Parse(Console.ReadLine() ?? "0");  //получаем число и проверяем на нуль
if (num >= 100)
{
    if (num <= 999)
    {
        num = (num / 1);
        num = (num % 10);
    }
    Console.WriteLine(num);
        
        if (num > 999)
    {
        num = (num / 10);
        num = (num % 10);
    }
    
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

