using System.Runtime.CompilerServices;

namespace task5;

public class Calculator
{
    public double _a;
    public double _b;
    public string _operator;

    public Calculator(double a, string znak, double b)
    {
        _a = a;
        _b = b;
        _operator = znak;
            switch (znak)
            {
                case "*":
                    Console.WriteLine($"{a}{znak}{b}={Multiplication()}");
                    break;
                case "/":
                    Console.WriteLine($"{a}{znak}{b}={Division()}");
                    break;
                case "+":
                    Console.WriteLine($"{a}{znak}{b}={Plass()}");
                    break;
                case "-":
                    Console.WriteLine($"{a}{znak}{b}={Minus()}");
                    break;
                default: throw new Exception("Такогї  операції немає");
            }
      
       
    }

    private double Plass()
    {
        return _a + _b;
    }

    private double Minus()
    {
        return _a - _b;
    }

    private double Multiplication()
    {
        return _a * _b;
    }

    private double Division()
    {
        try
        {
            return _a / _b;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}