namespace TestProject1;

public class Author
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    
    public string city { get; set; }
    public int age { get; set; }
    public int budget  {get; set;}
    private bool readyToPublic = false;

    public Author(string fname, string lname, string city_, int age_, int budget_)
    {
        firstName = fname;
        lastName = lname;
        city = city_;
        age = age_;
        budget = budget_;
    }

    public Book writeBook(string bname, string genre, int wantTirage)
    {
        Author author = this as Author;
        Book book = new Book(bname, genre, wantTirage, author);
        readyToPublic = true;
        return book;
    }
    
    public void goCity(string city_)
    {
        city = city_;
    }

    public bool checkState()
    {
        return readyToPublic;
    }

}