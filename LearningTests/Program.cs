using System;
using System.Threading.Tasks;
using LearningTests.Tax;

namespace LearningTests
{
    class Program
    {
        private static Calculator calculator;
        static async Task Main(string[] args)
        {

            await RunCalculationSalary();
            calculator = new Calculator();
            
            
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("type it first number:");
            var number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("type it second number:");
            var number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("type it operação operation");
            var operation = Console.ReadLine();

            var result = 0m;

            result = operation switch
            {
                "+" => calculator.Add(number1, number2),
                "-" => calculator.Subtract(number1, number2),
                "/" => calculator.Share(number1, number2),
                "*" => calculator.Multiply(number1, number2),
                _ => throw new ArgumentException("Operation not valid")
            };

            Console.WriteLine($"Resultado: {result}");
        }


        private static async Task RunCalculationSalary()
        {
            Console.WriteLine("type it salary:");
            var salario = decimal.Parse(Console.ReadLine());
            var resultadoSalario = await (new CalculatorTax(new ServiceTaxIncome()).CalculateSalaryLiquid(salario));
            Console.WriteLine($"salary Liquid: {resultadoSalario}");
        }
    }
}
