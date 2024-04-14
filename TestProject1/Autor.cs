namespace TestProject1;

public class Autor
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public int budget = 20000;
    private bool readyToPublic = false;

    public Autor(string fname, string lname, int a)
    {
        firstName = fname;
        lastName = lname;
        age = a;
    }

    public void writeBook()
    {

        readyToPublic = true;
    }

    public bool checkState()
    {
        return readyToPublic;
    }

}