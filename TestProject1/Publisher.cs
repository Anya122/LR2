namespace TestProject1;
// Контроллер 
public class Publisher
{
    public int num;
    public Author author;
    public Book book;
    public PublishingHouse house;
    public Critic critic;
    public DataBase database;
    
    public Publisher(string afname, string alname, string acity, int budget, string bname, int tirage,  string genre, string hname, string hcity, int curw, int maxw, string cname, int stric, int num_)
    {
        author = new Author(afname, alname, acity, budget);
        book = author.writeBook(bname, genre, tirage);

        house = new PublishingHouse(hname, hcity, curw, maxw);
        critic = house.employCritic(cname, stric);

        database = new DataBase();

        num = num_;

    }
}