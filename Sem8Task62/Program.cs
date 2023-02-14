// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


        int[,] array = new int[4, 4]; //создаем массив опеределенного размера и указываем количество колонок и рядов
        int value = 1;
        int minCol = 0;
        int maxCol = 3;
        int minRow = 0;
        int maxRow = 3;

        while (value <= 16)
        {
            for (int i = minCol; i <= maxCol; i++) //проходимся по колонкам
            {
                array[minRow, i] = value;
                value++;
            }

            for (int i = minRow + 1; i <= maxRow; i++) //проходимся по рядам
            {
                array[i, maxCol] = value;
                value++;
            }

            for (int i = maxCol - 1; i >= minCol; i--)
            {
                array[maxRow, i] = value;
                value++;
            }

            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                array[i, minCol] = value;
                value++;
            }

            minCol++;
            minRow++;
            maxCol--;
            maxRow--;
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
 