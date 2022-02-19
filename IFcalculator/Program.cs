using System;

namespace IFcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNum, SecondNum, Result = 0;
            string symbol;
            bool check;

            Console.WriteLine("КАЛЬКУЛЯТОР с использованием if/else");
            Console.WriteLine("Введите число 1");
            FirstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            SecondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию +, -, *, /");
            symbol = Console.ReadLine();

            check = symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";

            if (symbol == "+")
            {
                Result = FirstNum + SecondNum;
            }
            if (symbol == "-")
            {
                Result = FirstNum - SecondNum;
            }
            if (symbol == "*")
            {
                Result = FirstNum * SecondNum;
            }
            if (symbol == "/")
            {
                if (SecondNum == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    check = false;
                }
                else
                {
                    Result = FirstNum / SecondNum;
                }
            }
            if (check)
            {
                Console.WriteLine(FirstNum + " " + symbol + " " + SecondNum + " = " + Result);
            }
            else
            {   
                if(symbol != "/")
                {
                    Console.WriteLine("Не знаю такой операции");
                }
                
            }
        }
    }
}
