namespace TestProject1;

public class Tests_Script
{
    [Test]
    public void Test4_1_1()
    {
        var publisher = new Publisher("Anna", "Arkhipova", "Izhevsk", 300000, "Kotenok Koshunya", 3, "fantasy", "Detskoe",
            "Moscow", 1, 3000, "Alex", 5, 999);    
        Assert.That(publisher.getAnswer(), Is.EqualTo("Книга не выпущена. [ОТКАЗ НА ЭТАПЕ ПОДАЧИ ЗАЯВКИ]"));
    }
    
    [Test]
    public void Test4_2_1()
    {
        var publisher = new Publisher("Anna", "Arkhipova", "Izhevsk", 300000, "Kotenok Koshunya", 3, "fantasy", "Detskoe",
            "Izhevsk", 1, 3000, "Alex", 5, 999);    
        Assert.That(publisher.getAnswer(), Is.EqualTo("Книга не выпущена. [ЭТО ПЛАГИАТ]"));
    }
    
    [Test]
    public void Test4_3_1()
    {
        var publisher = new Publisher("Anna", "Arkhipova", "Izhevsk", 300, "Houmik and the City", 3000, "fantasy", "Detskoe",
            "Izhevsk", 1, 3000, "Alex", 0, 999);    
        
        publisher.goCritic();
        Assert.That(publisher.getAnswer(), Is.EqualTo("Книга не выпущена. [НЕ ХВАТИЛО ДЕНЕГ]"));
    }
    
    [Test]
    public void Test4_3_2()
    {
        var publisher = new Publisher("Anna", "Arkhipova", "Izhevsk", 300000, "Houmik and the City", 30, "fantasy", "Detskoe",
            "Izhevsk", 1, 3000, "Alex", 0, 999);    
        
        publisher.goCritic();
        Assert.That(publisher.getAnswer(), Is.EqualTo("Книга выпущена за свой счет."));
    }
    
    [Test]
    public void Test4_4_1()
    {
        var publisher = new Publisher("Anna", "Arkhipova", "Izhevsk", 300000, "Houmik and the City", 30, "fantasy", "Detskoe",
            "Izhevsk", 1, 3000, "Alex", 5, 999);
        publisher.goCritic();
        publisher.book.mark = 50; // чтобы точно оценку прошло (без этого есть шанс 20%, что оценка критика будет плохой)
        Assert.That(publisher.getAnswer(), Is.EqualTo("Книга выпущена по договору."));
    }
    
    
    

}