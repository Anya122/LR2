namespace TestProject1;

public class CashBox: PublishingHouse
{
    public int cost { get; set; }
    public string houseName { get; set; }
    public bool IsPaied { get; set; }
    
    public CashBox( Book book, PublishingHouse house) : base(house.houseName, house.city, house.currentWorkload, house.maxWorkload)
    {
        houseName = house.houseName;
        cost = countCost(book);
    }

    public int countCost(Book book)
    {
        return book.pages * book.wantTirage / 10;
    }

    public bool toPay(Book book, DataBase dbase)
    {
        if (book.budget >= cost)
        {
            IsPaied = true;
            book.IsPublished = true;
            dbase.addCurrentBook(book.GetAuthorlName(), book.bookName);
            book.budget -= cost;
        }
        else
        {
            IsPaied = false;
        }

        return IsPaied;

    }
    
    public bool getPaied()
    {
        return IsPaied;
    }
}