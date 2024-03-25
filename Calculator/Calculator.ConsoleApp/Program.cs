using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    Console.WriteLine("Witaj w aplikacji !!KALKULATOR!!");

                    Console.WriteLine("Podaj pierwszą liczbę: ");
                    var number1 = GetInput();

                    Console.WriteLine("Jakie działanie chcesz wykonać? Masz do wyboru: '+', '-', '*', '/'.");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj drugą liczbę: ");
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik Twojego działania to: {result}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą!");
            return input;
        }
        private static double Calculate(double number1, double number2, string operation) 
        {
             switch (operation)
             {
                    case "+":
                        return  number1 + number2;

                    case "-":
                        return  number1 - number2;
                        
                    case "*":
                        return  number1 * number2;
                        
                    case "/":
                        return  number1 / number2;
                        
                    default:
                        throw new Exception("Wybrałeś złą operację!\n");
             }
        }
    }
}