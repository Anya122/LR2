using System.Collections.Generic;
namespace TestProject1;

public class DataBase
{
    public bool checkComplited = false;
    public List<KeyValuePair<string, string>> books = new List<KeyValuePair<string, string>>();

    public DataBase()
    {
        
    }
    public void addCurrentBook(Book book)
    {
        books.Add(new KeyValuePair<string, string>(book.GetAuthorlName(), book.bookName));
        checkComplited = false;
    }
    public void addBooks()
    {
        books.Add(new KeyValuePair<string, string>("Arkhipova", "Kotenok Koshunya"));
        books.Add(new KeyValuePair<string, string>("Limonnikov", "Avtobiografia"));
        books.Add(new KeyValuePair<string, string>("Tulegenov", "Gleb Memuars"));
        books.Add(new KeyValuePair<string, string>("Gazizylin", "Anime Tatarin"));
        books.Add(new KeyValuePair<string, string>("Dolgoff", "Skyff adventure"));
        books.Add(new KeyValuePair<string, string>("Krakozyabra", "Kir Kir Kir"));
        books.Add(new KeyValuePair<string, string>("Chuppkabra", "Houmik"));
        checkComplited = false;
    }

    public bool checkBook(Book book)
    {
        foreach (var pair in books)
        {
            if (book.bookName == pair.Value)
            {
                checkComplited = true;
                return false;
            }
        }

        checkComplited = true;
        return true;
    }

    public bool getCheckComplited()
    {
        return checkComplited;
    }
}