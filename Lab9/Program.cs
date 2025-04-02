using System;
using CalculatorLib1;

namespace Lab9
{
    internal class CalculatorApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Доступные операции:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");

            var calculator = new Calculator();

            try
            {
                Console.Write("Выберите операцию (1-6): ");
                int operation = int.Parse(Console.ReadLine());

                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                double num2 = 0;
                if (operation != 6) 
                {
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                }

                double result = operation switch
                {
                    1 => calculator.Add(num1, num2),
                    2 => calculator.Subtract(num1, num2),
                    3 => calculator.Multiply(num1, num2),
                    4 => calculator.Divide(num1, num2),
                    5 => calculator.Power(num1, num2),
                    6 => calculator.SquareRoot(num1),
                    _ => throw new InvalidOperationException("Неверный выбор операции")
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
