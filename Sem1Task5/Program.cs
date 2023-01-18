// Задача № 5 

//Считываем данные с консоли
string? inputNumLine = Console.ReadLine();
//Проверяем чтобы данные не были пустыми
if(inputNumLine!=null)
{
    // парсим введеное число
    int inputNumberA = int.Parse(inputNumLine);
    // вводим промежуточное значение
    int inputNumberC = inputNumberA*(-1);
// выходные значения
    string outNumLine = string.Empty;

    while(inputNumberC < inputNumberA)
    {
        outNumLine = outNumLine + inputNumberC + ",";
        inputNumberC = inputNumberC + 1;
    }
    outNumLine = outNumLine + inputNumberA;
    Console.WriteLine(outNumLine);
}
