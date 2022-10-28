using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char openingBracket = '(';
            char closingBracket = ')';
            int currentDepth = 0;
            int maxDepth = 0;

            Console.Write("Введите скобочное выражение из круглых скобок: ");
            userInput = Console.ReadLine();

            foreach (var symbol in userInput)
            {
                if (symbol == openingBracket)
                {
                    currentDepth++;

                    if (currentDepth > maxDepth)
                    {
                        maxDepth = currentDepth;
                    }
                }
                else if (symbol == closingBracket)
                {
                    currentDepth--;

                    if (currentDepth < 0)
                    {
                        Console.WriteLine("Скобочное выражение некоректно.");
                        break;
                    }
                }
            }

            if (currentDepth == 0)
            {
                Console.WriteLine($"Скобочное выражение корректно.\nЕго максимальная глубина {maxDepth}");
            }
            else if (currentDepth > 0)
            {
                Console.WriteLine("Скобочное выражение некоректно.");
            }
        }
    }
}

