// Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.


int ReadData(string msg) //Метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0"); // сразу идеть проверка на нуль
}

void PrintData(string msg1, int msg2) //Выводим результат пользователю
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSimple(int numA) //метод принимает число и возвращает сумму. 
                        //тип int т.е. мы собираемся возврашщать значение, чтобы компилятор не ругася
{ 
    int sumOfNum = 1; //вводим переменную sumofnum и ее мы и будем выводить из метода в return
    for(int i=2;i<=numA;i++) //испльзуем цикл for и будем по одному числу суммировать.
                            //мы начинаем сразу с 2х чтобы уменьшить количество вычислний, можно с 1цы начать
    {
        sumOfNum+=i;
    }
    return sumOfNum;
}

int SumGauss(int numA) //формула по гауссу это будет 2ое решение задачи
{
    return (numA*(numA+1))/2;
}

int numberA = ReadData("Введите число A"); //получаем число от пользователя

DateTime d1 = DateTime.Now; //эта конструкция изчасов компа и в переменную кладем время которое сейчас, а потом выводим разницу
int res1 = SumSimple(numberA); //обращаемся к методу, предварительно передав ему А
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А(SumSimple): ",res1); //выводим результат
PrintData("Сумма чисел от 1 до А(SumGauss): ",res2);
