using System;

namespace LinesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesAmount = 52;
            int imagesInLine = 3;

            Console.WriteLine("Полных строк: {0}\nОсталось элементов: {1}", (int)(imagesAmount / imagesInLine), imagesAmount % imagesInLine);
            Console.ReadKey();
        }
    }
}
