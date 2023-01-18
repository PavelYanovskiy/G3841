// Задача № 7 
// программа которая принимает на вход трехзначное число и 
//на выход показывает послендюю цифру этого числа

//Считываем данные с консоли
string? inputNumLine = Console.ReadLine();
//Проверяем чтобы данные не были пустыми
if(inputNumLine!=null)
{
    // перевели в целочисленное
    int inputNumberA = int.Parse(inputNumLine);
    
    // взяли остаток от деления 
    int lastDigit = inputNumberA%10;
// последнюю цифру выводим пользователю
    Console.WriteLine(lastDigit);
}

