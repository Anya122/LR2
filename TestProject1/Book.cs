namespace TestProject1;

public class Book : Author
{
    public string bookName { get; set; }
    public string genre { get; set; }

    public int pages = 0;
    public int wantTirage { get; set; }
    public bool IsPublished = false;
    public bool IsDestroyed = false;

    public Book(string bname, string genre_, int wantTirage_, Author author) : base(author.firstName, author.lastName, author.city, author.age, author.budget)
    {
        bookName = bname;
        genre = genre_;
        wantTirage = wantTirage_;
    }
    
    public void setPages()
    {
        Random random = new Random();
        pages = random.Next(10, 1000);
    }
    
    public void destroyBook()
    {
        IsDestroyed = true;
    }

    public bool checkState()
    {
        return IsPublished;
    }
    
    public bool checkDestroy()
    {
        return IsDestroyed;
    }
    
    public string GetAuthorCity()
    {
        return city;
    }
}