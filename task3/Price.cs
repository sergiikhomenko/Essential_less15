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
public struct Price
{
    public string _nameOfGoods { set; get; }
    public string _shop { set; get; }
    public decimal _price { set; get; }

    public Price(string nameOfGoods,string shop, decimal price)
    {
        _nameOfGoods = nameOfGoods;
        _shop = shop;
        _price = price;
    }

}