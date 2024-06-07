using System.Linq.Expressions;

namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно описати структуру з іменем Price, що містить такі поля:
   • назва товару;
   • назва магазину, де продається товар;
   • вартість товару у гривнях.
   Написати програму, яка виконує такі дії:
   • введення з клавіатури даних до масиву, що складається з двох елементів типу Price 
   (записи мають бути впорядковані в алфавітному порядку за назвами магазинів);
   • виведення на екран інформації про товари, що продаються в магазині,
    назва якого введена з клавіатури (якщо такого магазину немає, вивести виняток).
 */
class Program
{
    static void Main(string[] args)
    {
        Price[] prices = new Price[2];
        for (int  i = 0;  i < prices.Length;  i++)
        {
            Console.WriteLine("Введіть назву товару");
            string goods = Console.ReadLine();
            Console.WriteLine("Введіть назву магазину");
            string shop = Console.ReadLine();
            Console.WriteLine("Введіть ціну  товару");
            Decimal.TryParse(Console.ReadLine(), out decimal price);
            Price item = new Price(goods, shop, price);
            prices[i] = item;
        }
        Array.Sort(prices, (x, y) => string.Compare(x._shop, y._shop, StringComparison.Ordinal));

        Console.WriteLine("Введіть магазин для пошуку");
        string shopToFind = Console.ReadLine();
        bool res  = false;
        foreach (var shop in prices)
        {
                if (shopToFind == shop._shop)
                {
                    Console.WriteLine($"Товари що прадаються в магазині {shopToFind}");
                    Console.WriteLine($"Назва товару: {shop._nameOfGoods} Ціна товару {shop._price}");
                    res = true;
                }
        }

        if (!res)
        {
            throw new Exception("Такого магазину не знайдено");
        }
    }
}