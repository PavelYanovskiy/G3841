// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// double ReadData(string msg) //Метод считывает данные от пользователя
// {
//     Console.WriteLine(msg);
//     return double.Parse(Console.ReadLine() ?? "0");
// }

// double b1 = ReadData("Введите значение b1: "); //Просим пользователя ввести данные точек
// double b2 = ReadData("Введите значение b2: ");
// double k1 = ReadData("Введите значение k1: ");
// double k2 = ReadData("Введите значение k2: ");

// double x = (b2 - b1) / (k1 - k2); //Решением уравненения k1*x + b1 = k2*x + b2 вычисляем x; x = (b2 - b1)/(k1 - k2)
// double y = k1 * x + b1; //вычисляем точку у

// Console.WriteLine("Точка пересечения прямых: (" + x + ", " + y + ")"); //выводим пользователю результат


// * Найдите площадь треугольника образованного пересечением 3 прямых
double ReadData(string msg) //Метод считывает данные от пользователя
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

double x1 = ReadData("Введите значение x1: "); //Просим пользователя ввести данные точек
double y1 = ReadData("Введите значение y1: ");
double x2 = ReadData("Введите значение x2: ");
double y2 = ReadData("Введите значение y2: ");
double x3 = ReadData("Введите значение x3: ");
double y3 = ReadData("Введите значение y3: ");


double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2); //метод вычисляет площадь треугольника


Console.WriteLine($"Площадь треугольника равна {area}");         // Выводим результат пользователю

