// Задача № 11
//Напишите программу, при которой она случайно выводит трехзначное число
//и удаляет вторую цифру этого числа


// System.Random newSintezator = new System.Random(); // запускаем синтезатор числе
// int num = newSintezator.Next(100,1000); //получаем число

// int digitfirst = num/100; //берем число и делим на 100. тогда две последние цифры отбросятся
// int digitLast = num%10; //чтобы получить последнее число нужно получить остаток деления на 10
// Console.WriteLine(num); //выводит это число
// Console.WriteLine(digitfirst*10 + digitLast); //собираем обратно число

// System.Random numSintezator = new System.Random();
// int num = numSintezator.Next(100, 1000);
// int digit1 = num/100;
// int digit2 = num%10;
//  Console.WriteLine(num);
// Console.WriteLine(digit1*10+digit2);

System.Random random = new System.Random(); //создаем объект

int randomNumber = random.Next(100,1000); //получаем рандомное число

Console.WriteLine("число: " + randomNumber); //печатаем число чтобы увидел пользователь

string value = randomNumber.ToString(); //превращаем его в строку

char[] numberArray = value.ToCharArray(); //превращаем его в массив char

Console.WriteLine(numberArray[0] + "" + numberArray[2]); //выводим первое и последнее число 
