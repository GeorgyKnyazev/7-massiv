using System;

namespace _7_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineWistText = "Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки";
            string[] massivOfLineText = lineWistText.Split();

            foreach (string massivLine in massivOfLineText)
            {
                Console.WriteLine(massivLine);
            }
        }
    }
}
