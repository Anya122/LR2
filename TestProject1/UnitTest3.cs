namespace TestProject1;

public class Test_state
{
    [Test]
    public void Test3_1_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        Assert.IsFalse(author.checkState());
    }
    
    [Test]
    public void Test3_1_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Skynks", "scifi", 1000090);
        Assert.IsTrue(author.checkState());
    }
    
    [Test]
    public void Test3_2_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.IsFalse(book.checkDestroy());
    }
    
    [Test]
    public void Test3_2_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        book.destroyBook();
        Assert.IsTrue(book.checkDestroy());
    }
    
    [Test]
    public void Test3_2_3()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.IsFalse(book.checkState());
    }
    
    [Test]
    public void Test3_2_4()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        var database = new DataBase();
        var house = new PublishingHouse("Dom Squrtsa", "Piter", 5000, 20000);
        var contract = new Contract(456, book, house);
        
        contract.Sign(book, database);
        Assert.IsTrue(book.checkState());
    }
    
    [Test]
    public void Test3_2_5()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 2000000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        var database = new DataBase();
        var house = new PublishingHouse("Dom Squrtsa", "Piter", 5000, 20000);
        var cashBox = new CashBox(book, house);

        cashBox.toPay(book, database);
        Assert.IsTrue(book.checkState());
    }
    
    [Test]
    public void Test3_3_1()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        Assert.IsTrue(house.checkState());
    }
    
    [Test]
    public void Test3_3_2()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 450, 60);
        Assert.IsFalse(house.checkState());
    }
    
    [Test]
    public void Test3_3_3()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        Assert.IsTrue(house.checkOpen());
    }
     
    [Test]
    public void Test3_3_4()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        house.Close();
        Assert.IsFalse(house.checkOpen());
    }
    
    [Test]
    public void Test3_4_1()
    {
        var database = new DataBase();
        Assert.IsFalse(database.getCheckComplited());
    }
     
    [Test]
    public void Test3_4_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Skynks", "scifi", 1000090);
        
        var database = new DataBase();
        database.addBooks();
        var a = database.checkBook(book);
        
        Assert.IsTrue(database.getCheckComplited());
    }
    
    [Test]
    public void Test3_6_1()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var contract = new Contract(1234, book, house);
        Assert.IsFalse(contract.getSign());
    }
    
    [Test]
    public void Test3_6_2()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        var database = new DataBase();
        
        var contract = new Contract(1234, book, house);
        contract.Sign(book, database);
        Assert.IsTrue(contract.getSign());
    }
    
    [Test]
    public void Test3_7_1()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var cashBox = new CashBox(book, house);
        Assert.IsFalse(cashBox.getPaied());
    }
    
    [Test]
    public void Test3_7_2()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        var database = new DataBase();
        
        var cashBox = new CashBox(book, house);
        cashBox.toPay(book, database);
        Assert.IsFalse(cashBox.getPaied());
    }
    
    [Test]
    public void Test3_7_3()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 2000000);
        var book = new Book("Orange is new Black", "drama",  1000, author);
        var database = new DataBase();
        
        var cashBox = new CashBox(book, house);
        cashBox.toPay(book, database);
        Assert.IsTrue(cashBox.getPaied());
    }
}