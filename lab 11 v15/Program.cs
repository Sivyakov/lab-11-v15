using System;

namespace lab_11_v15
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate(7, 3);
            Console.WriteLine("Целая часть от деления  = {0}", calculate.Multiplication());
            calculate.Inf();
            Console.ReadKey();
        }
    }

    class Calculate
    {
        double number1, number2;

        public Calculate(double x, double y)
        {
            number1 = x;
            number2 = y;
        }
        public void Inf()
        {
            Console.WriteLine("Поле1 = {0}\nПоле2 = {1} ", number1, number2);
        }
        public double Multiplication()
        {
            return Math.Floor(number1/number2);
        }
    }
}
