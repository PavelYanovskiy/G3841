// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int coordX = ReadData("Введите координату X"); //объявляем переменную
int coordY = ReadData("Введите координату Y");
PrintQuterTest(coordX,coordY); //вызвали метод тест точек на плоскости


int ReadData(string msg) //Метод читает данные от пользователя (string это строка)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0"); //переменную преобразуем в значение и выдаем наружу метода
}

// Метод определяет четверть по координатам точки (void  - это метод "тишина" туда инфомация только попадает)
//PrintQuterTest  - это тест на четверть
void PrintQuterTest(int X, int Y) 
{
    if (X > 0 && Y > 0) Console.WriteLine("Точка в четверти 1");
    if (X > 0 && Y < 0) Console.WriteLine("Точка в четверти 2");
    if (X < 0 && Y < 0) Console.WriteLine("Точка в четверти 3");
    if (X < 0 && Y > 0) Console.WriteLine("Точка в четверти 4");
}