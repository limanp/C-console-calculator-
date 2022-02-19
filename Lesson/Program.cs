using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            bool trys = int.TryParse(Console.ReadLine(), out number);

            if(trys)
            {
                Console.WriteLine("Число было конвертировано" + number);
            }
            else
            {
                Console.WriteLine("Фиг тебе а не конвертация!");
            }
        }
    }
}
