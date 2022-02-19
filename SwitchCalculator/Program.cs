using System;

namespace SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNum, SecondNum, Result;
            string symbol;

            Console.WriteLine("КАЛЬКУЛЯТОР с использованием SWITCH");
            Console.WriteLine("Введите число 1");
            FirstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            SecondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию +, -, *, /");
            symbol = Console.ReadLine();

            switch(symbol)
            {
                case "+":
                    Result = FirstNum + SecondNum;
                    Console.WriteLine(FirstNum + " " + symbol + " " + SecondNum + " = " + Result);
                    break;
                case "-":
                    Result = FirstNum + SecondNum;
                    Console.WriteLine(FirstNum + " " + symbol + " " + SecondNum + " = " + Result);
                    break;
                case "*":
                    Result = FirstNum + SecondNum;
                    Console.WriteLine(FirstNum + " " + symbol + " " + SecondNum + " = " + Result);
                    break;
                case "/":
                    switch(SecondNum)
                    {
                        case 0:
                            Console.WriteLine("На ноль делить нельзя!");
                            break;
                        default:
                            Result = FirstNum / SecondNum;
                            Console.WriteLine(FirstNum + " " + symbol + " " + SecondNum + " = " + Result);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Я не знаю такой операции!");
                    break;
            }
        }
    }
}
