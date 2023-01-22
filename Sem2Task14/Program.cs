// Задача 14

// Console.Write("Введите число:"); //просим ввести число
// int num1 = int.Parse(Console.ReadLine() ?? "0");  //получаем число
// int res1 = num1 % 7; //получаем остатки от деления
// int res2 = num1 % 23;
// if ((res1 == 0) && (res2 ==0 )) //проверяем два условия, выражение проверяется внутри, остаток от деления равено 0
// логическое "и" обознается символаи && , а логическое "или" обозначается ||

// {
//     Console.Write("Число кратно 7 и 23"); //выводим
// }
// else
// {
//     Console.Write("Число некратно 7 и 23");
// }
// int num = int.Parse(Console.ReadLine() ?? "0");
// if ((num%7==0)&&(num%23==0)){
//     Console.WriteLine("кратное");
// }else{
//     Console.WriteLine("не кратное 7и и 23ём");
// }
int num1 = int.Parse(Console.ReadLine()??"0"); //вводим

int res1 = num1%7;
int res2 = num1%23;
if((res1==0)&&(res2==0))
{
Console.WriteLine("Кратное ");
}

else
{
Console.WriteLine("Не кратно " + res1 + " " + res2);
}
