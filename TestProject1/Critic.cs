namespace TestProject1;

public class Critic : PublishingHouse
{
    public string name { get; set; }
    public string houseName { get; set; }
    public int strictness { get; set; } // от 0 до 5
    
    public Critic(string name_, int strictness_, PublishingHouse house) : base(house.houseName, house.city, house.currentWorkload, house.maxWorkload)
    {
        name = name_;
        strictness = strictness_;
        houseName = house.houseName;
    }

    public void reviewBook(Book book)
    { 
        Random random = new Random(); 
        book.mark = strictness * random.Next(0, 20); 
    }

    public bool goodBook(Book book)
    {
        if (book.mark >= 30)
            return true;
        else 
            return false;
    }
}