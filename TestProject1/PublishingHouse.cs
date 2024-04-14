namespace TestProject1;

public class PublishingHouse
{
    public string houseName { get; set; }
    
    public string city { get; set; }
    
    public int currentWorkload  {get; set;}
    
    public int maxWorkload  {get; set;}
    
    private bool readyToPublic;
    private bool isOpen = true;

    public PublishingHouse(string hname, string city_, int currentWorkload_, int maxWorkload_)
    {
        houseName = hname;
        city = city_;
        currentWorkload = currentWorkload_;
        maxWorkload = maxWorkload_;
        if (currentWorkload < maxWorkload) readyToPublic = true;
        else readyToPublic = false;
    }

    public bool startPublic(Book book)
    {
        if (isOpen && readyToPublic && book.GetAuthorCity() == city)
        {
            if (currentWorkload + book.wantTirage > maxWorkload)
            {
                book.wantTirage = maxWorkload - currentWorkload;
                currentWorkload = maxWorkload;
            }
            else
            {
                currentWorkload += book.wantTirage;
            }
            readyToPublic = true;
            return readyToPublic;
        }
        else 
        {
            readyToPublic = false;
            return readyToPublic;
        }
    }

    public bool checkState()
    {
        return readyToPublic;
    }
    public bool checkOpen()
    {
        return isOpen;
    }

    public void Open()
    {
        isOpen = true;
    }

    public void Close()
    {
        isOpen = false;
    }
    
    public Critic employCritic(string name, int strictness)
    {
        PublishingHouse house = this as PublishingHouse;
        Critic critic = new Critic(name, strictness, house);
        return critic;
    }

    public Contract makeConract(int num, Book book)
    {
        PublishingHouse house = this as PublishingHouse;
        Contract contract = new Contract(num, book, house);
        return contract;
    }



}