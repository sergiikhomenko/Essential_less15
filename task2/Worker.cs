namespace task2;
/*
 Потрібно описати структуру з ім'ям Worker, що містить такі поля:
   • прізвище та ініціали працівника;
   • назва займаної посади;
   • рік надходження працювати.
   Написати програму, яка виконує такі дії:
   • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
   • якщо значення року введено не у відповідному форматі видає виняток;
   • виведення на екран прізвища працівн
 */
public struct Worker
{
    private string _pib;
    private string _post;
    private DateTime _year;
    
    public Worker(string pib,string post, DateTime year)
    {
        _pib = pib;
        _post = post;
        _year = year;
    }

    public DateTime Year
    {
        get { return _year; }
    }

    public string PIB
    {
        get { return _pib; }
    }

    public string Post
    {
        get { return _post; }
    }

}