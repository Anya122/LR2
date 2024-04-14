namespace TestProject1;

public class Contract: PublishingHouse
{
    public int number { get; set; }
    public string houseName { get; set; }
    public int authorProfit { get; set; }

    public bool IsSign { get; set; }
    
    public Contract( int number_, Book book, PublishingHouse house) : base(house.houseName, house.city, house.currentWorkload, house.maxWorkload)
    {
        number = number_;
        houseName = house.houseName;
        authorProfit = countProfit(book);
    }

    public int countProfit(Book book)
    {
        return book.mark * book.wantTirage / 2;
    }

    public void Sign(Book book, DataBase dbase)
    { 
        IsSign = true;
        book.IsPublished = true;
        dbase.addCurrentBook(book.GetAuthorlName(), book.bookName);
    }
    
    public bool getSign()
    {
        return IsSign;
    }
    
}