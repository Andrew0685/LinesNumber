using System;

namespace LinesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesAmount = 52;
            int imagesInLine = 3;
            int linesAmount;
            int imagesStay;

            linesAmount = imagesAmount / imagesInLine;
            imagesStay = imagesAmount % imagesInLine;

            Console.WriteLine("Полных строк: {0}\nОсталось элементов: {1}", linesAmount, imagesStay);
            Console.ReadKey();
        }
    }
}
