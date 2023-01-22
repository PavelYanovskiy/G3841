//Задача № 12. Программа, которая принимает на вход два числа и 
//выводит,является ли 2ое число кратное первому. 
//Если 2 число кратно первому то программа выводит остаток от деления


int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int result = num2%num1;
if(result==0)
{
    Console.WriteLine("Кратное");
}
else
{
Console.WriteLine("Не кратно "+result);
}