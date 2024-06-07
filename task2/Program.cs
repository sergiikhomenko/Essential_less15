using System.Globalization;

namespace task2;
/*
 * Потрібно описати структуру з ім'ям Worker, що містить такі поля:
   • прізвище та ініціали працівника;
   • назва займаної посади;
   • рік надходження працювати.
   Написати програму, яка виконує такі дії:
   • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
   • якщо значення року введено не у відповідному форматі видає виняток;
   • • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.
 */
class Program
{
    static void Main(string[] args)
    {
        string pib, post;
        DateTime dateOfBirth;
        string format = "yyyy";
        Worker[] workers = new Worker[5];
        for (int i = 0; i < workers.Length; i++)
        {
            Console.WriteLine("Введіть ПІБ");
            pib = Console.ReadLine();
            Console.WriteLine("Введіть посаду");
            post = Console.ReadLine();
            Console.WriteLine("Введіть дату прийняття");
            string dateString = Console.ReadLine();
            try
            {
                dateOfBirth =
                    DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Невірний формат");
                throw;
            }

            Worker worker = new Worker(pib, post, dateOfBirth);
            workers[i] = worker;
        }

        Array.Sort(workers, (x, y) => string.Compare(x.PIB, y.PIB, StringComparison.Ordinal));
        
        Console.WriteLine("Введіть стаж");
        Int32.TryParse(Console.ReadLine(), out int yearsOfExperience);
        foreach (var worker in workers)
        {
            int experience = (DateTime.Now - worker.Year).Days / 365;
            if (experience >yearsOfExperience)
            {
                Console.WriteLine($"{worker.PIB} {worker.Post} {worker.Year.Year}");
            }
        }
    }

}