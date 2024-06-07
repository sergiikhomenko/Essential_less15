namespace task5;
/*
 * Завдання 5
 Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
  Створіть клас Calculator. У тілі класу створіть чотири методи для арифметичних
   дій: Add – додавання, Sub – віднімання, Mul – множення, 
   Div – розподіл. Метод поділу повинен перевірити поділ на 
   нуль, якщо перевірка не проходить, згенерувати виняток. 
   Користувач вводить значення, над якими хоче зробити операцію та
    вибрати саму операцію. 
    У разі виникнення помилок повинні викидатися винятки.
 */
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введіть число А");
            Double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Введіть число В");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Введіть знак операції");
            string znak = Console.ReadLine();
            Calculator calculator = new Calculator(a, znak, b);
        }
        
        
    }
}