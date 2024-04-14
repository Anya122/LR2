namespace TestProject1;

public class Autor
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public int budget  {get; set;}
    private bool readyToPublic = false;

    public Autor(string fname, string lname, int age_, int budget_)
    {
        firstName = fname;
        lastName = lname;
        age = age_;
        budget = budget_;
    }

    public void writeBook(string bname, string genre, int wantTirage)
    {
        Book book = new Book(bname, genre, wantTirage);
        readyToPublic = true;
    }

    public bool checkState()
    {
        return readyToPublic;
    }

}