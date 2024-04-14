namespace TestProject1;

public class Book
{
    public string bookName { get; set; }
    public string genre { get; set; }

    public int pages = 0;
    public int wantTirage { get; set; }
    public bool IsPublished = false;
    public bool IsDestroyed = false;

    public Book(string bname, string genre_, int wantTirage_)
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
}