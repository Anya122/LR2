namespace TestProject1;

public class Tests_features
{
    [Test]
    public void Test1_1_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        Assert.That(author.firstName, Is.EqualTo("Anna"));
        Assert.That(author.lastName, Is.EqualTo("Arkhipova"));
    }
    
    [Test]
    public void Test1_1_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        Assert.That(author.city, Is.EqualTo("Izhevsk"));
    }
    
    [Test]
    public void Test1_1_3()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        Assert.That(author.budget, Is.EqualTo(20000));
    }
    
    [Test]
    public void Test1_2_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.That(book.bookName, Is.EqualTo("Orange is new Black"));
    }
    
    [Test]
    public void Test1_2_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.That(book.lastName, Is.EqualTo("Arkhipova"));
    }
    
    [Test]
    public void Test1_2_3()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.That(book.genre, Is.EqualTo("drama"));
    }
    
    [Test]
    public void Test1_2_4()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.That(book.wantTirage, Is.EqualTo(10000));
    }
    
    [Test]
    public void Test1_2_5()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        Assert.That(book.mark, Is.EqualTo(0));
    }
    
    [Test]
    public void Test1_3_1()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        Assert.That(house.houseName, Is.EqualTo("A-Zbuka"));
    }
    [Test]
    public void Test1_3_2()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        Assert.That(house.city, Is.EqualTo("Moscow"));
    }
    
    [Test]
    public void Test1_3_3()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        Assert.That(house.currentWorkload, Is.EqualTo(13));
        Assert.That(house.maxWorkload, Is.EqualTo(60));
    }
    
    [Test]
    public void Test1_4_1()
    {
        var database = new DataBase();
        Assert.IsNotEmpty(database.books);
    }
    
    [Test]
    public void Test1_5_1()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var critic = new Critic("Salivan", 4, house);
        Assert.That(critic.name, Is.EqualTo("Salivan"));
    }
    
    [Test]
    public void Test1_5_2()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var critic = new Critic("Salivan", 4, house);
        Assert.That(critic.strictness, Is.EqualTo(4));
    }
    
    [Test]
    public void Test1_6_1()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var contract = new Contract(1234, book, house);
        Assert.That(contract.number, Is.EqualTo(1234));
    }
    
    [Test]
    public void Test1_7_1()
    {
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var cashBox = new CashBox(book, house);
        Assert.That(cashBox.houseName, Is.EqualTo("A-Zbuka"));
    }

}