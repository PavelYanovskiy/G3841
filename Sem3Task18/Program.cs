// Задача № 18 Напишите программу, которая по заданному номер четверти
// указывает диапазон возможных координат точек в этой четверти

int qNum = ReadData("Введите номер четверти"); //объявляем переменную и вызываем метод риддата
PrintQuterAnswer(qNum);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод определяет допустимого диапазона координат точек по четверти
void PrintQuterAnswer(int num) //(int num) - это значит, что вводится только одно значение (нужной четверти)
{
    if (num > 0 && num < 5) //делаем проверку на номер четверти, есть ли  такой
    {
        if (num == 1) Console.WriteLine("X > 0, Y > 0");  //если кунам=1 то мы пишем координаты первой четверти
        if (num == 2) Console.WriteLine("X > 0, Y < 0");
        if (num == 3) Console.WriteLine("X < 0, Y < 0");
        if (num == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти!");
}