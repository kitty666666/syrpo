using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;

        Console.WriteLine("Вы ввели: " + inputString);
        Console.WriteLine("Количество символов в строке: " + length);

        Console.ReadKey(); // Чтобы программа не закрылась сразу после вывода результата
    }
}