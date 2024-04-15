namespace TestProject1;
// Контроллер 
public class Publisher
{
    public Author author;
    public Book book;
    public PublishingHouse house;
    public Critic critic;
    public DataBase database;
    public Contract contract;
    public CashBox cashBox;

    public int num;
    public bool needPay = false;
    public bool payFailed = false;
    public bool returnOnDB { get; set; }
    
    public Publisher(string afname, string alname, string acity, int budget, string bname, int tirage,  string genre, string hname, string hcity, int curw, int maxw, string cname, int stric, int num_)
    {
        author = new Author(afname, alname, acity, budget);
        book = author.writeBook(bname, genre, tirage);

        house = new PublishingHouse(hname, hcity, curw, maxw);
        critic = house.employCritic(cname, stric);
        
        database = new DataBase();
        database.addBooks();
        returnOnDB = !database.checkBook(book);
        num = num_;

    }

    public void goCritic()
    {
        critic.reviewBook(book);
        if(critic.goodBook(book))
        {
            contract = new Contract(num, book, house);
            contract.Sign(book, database);
        }
        else
        {
            cashBox = new CashBox(book, house);
            needPay = true;
            payFailed = !cashBox.toPay(book, database);
        }
    }
    public string getAnswer()
    {
        if (!house.startPublic(book))
        {
            return "Книга не выпущена. [ОТКАЗ НА ЭТАПЕ ПОДАЧИ ЗАЯВКИ]";
        }
        else if (returnOnDB)
        {
            return "Книга не выпущена. [ЭТО ПЛАГИАТ]";
        }
        else if (needPay && payFailed)
        {
            return "Книга не выпущена. [НЕ ХВАТИЛО ДЕНЕГ]";
        }
        else if (needPay && !payFailed)
        {
            return "Книга выпущена за свой счет.";
        }
        else
        {
            return "Книга выпущена по договору.";
        }
    }
}