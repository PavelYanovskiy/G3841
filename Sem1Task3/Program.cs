// Задача № 3
// Пользователь вводит число, а мы сообщаем какой день недели.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем чтобы данные не были пустыми
if(inputLine!=null)
{
//     // Вариант 1
//     // создаем массив с днями недели
//     string[] dayWeek = new string[7];
//     dayWeek[0] = "Понедельник";
//     dayWeek[1] = "Вторник";
//     dayWeek[2] = "Среда";
//     dayWeek[3] = "Четверг";
//     dayWeek[4] = "Пятница";
//     dayWeek[5] = "Суббота";
//     dayWeek[6] = "Воскресенье";
// // Парсим введеное число
// int inputNumber = int.Parse(inputLine);
// // Находим название дня недели по введеному номеру
// string outDayWeek = dayWeek[inputNumber-1];
// // Вводим данные в консоль
// Console.WriteLine(outDayWeek);
//Вариант 2 оператор SwitchCase
int inputNumber = int.Parse(inputLine);
// string outDayWeek = string.Empty;
// switch (inputNumber)
// {
//     case 1: outDayWeek = "понедельник"; break;
//     case 2: outDayWeek = "вторник"; break;
//     case 3: outDayWeek = "среда"; break;
//     case 4: outDayWeek = "четверг"; break;
//     case 5: outDayWeek = "пятница"; break;
//     case 6: outDayWeek = "суббота"; break;
//     case 7: outDayWeek = "воскресенье"; break;
//     default: outDayWeek = "Это не день недели!"; break;
// }
// Console.WriteLine(outDayWeek);
// Вариант 3

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
Console.WriteLine(outDayOfWeek);
}