using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;
        int countOfB = 0;

        foreach (char c in inputString)
        {
            if (c == 'б' || c == 'Б')
            {
                countOfB++;
            }
        }

        Console.WriteLine("Вы ввели: " + inputString);
        Console.WriteLine("Ты молодец)) пака");
        Console.WriteLine("Количество символов в строке: " + length);
        Console.WriteLine("Количество букв 'б' в строке: " + countOfB);

        Console.ReadKey(); // Чтобы программа не закрылась сразу после вывода результата
    }
}