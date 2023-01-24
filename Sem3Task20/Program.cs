// Задача № 20 Напишите программу, которая на входе принимает координаты двух точек
// и находит расстояние между этиму двумя точками в 2д пространстве

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
//Вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1, int x2, int y1, int y2) //double означает что число вещественное, не целое и принимает 4 координаты
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); //Math это математическиц метод. Sqrt - квадратный корень. 
                                                                    //это универсальная форма которая определяет в расстояние в любом пространстве
    return res; // раз есть doubleзначит должен быть return
}

//Вводим координаты точек
int coordX1 = ReadData("Введите координату x1");
int coordX2 = ReadData("Введите координату x2");
int coordY1 = ReadData("Введите координату y1");
int coordY2 = ReadData("Введите координату y2");

//Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

//Выдаем результат
PrintData("Расстояние между точками: ", len);

//Вариант программы в одну строчку, но он плохо читается.
// PrintData("Расстояние между точками: ",CalcLen(
//     ReadData("Введите координату x1"),
//     ReadData("Введите координату x2"),
//     ReadData("Введите координату y1"),
//     ReadData("Введите координату y1")));

