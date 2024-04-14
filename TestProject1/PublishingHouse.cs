namespace TestProject1;

public class PublishingHouse
{
    public string houseName { get; set; }
    
    public string city { get; set; }
    
    public int currentWorkload  {get; set;}
    
    public int maxWorkload  {get; set;}
    
    private bool readyToPublic = false;

    public PublishingHouse(string hname, string city_, int currentWorkload_, int maxWorkload_)
    {
        houseName = hname;
        city = city_;
        currentWorkload = currentWorkload_;
        maxWorkload = maxWorkload_;
    }

    public bool startPublic(Book book)
    {
        if (currentWorkload + book.wantTirage > maxWorkload)
        {
            readyToPublic = false;
            return readyToPublic;
        }
        else
        {
            currentWorkload += book.wantTirage;
            readyToPublic = true;
            return readyToPublic;
        }
    }

    public bool checkState()
    {
        return readyToPublic;
    }

}