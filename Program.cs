// See https://aka.ms/new-console-template for more information
public class Utente
{
    private string id;
    private string name;
    private string lastname;
    private int yearOfRegistration;

    public Utente(string id, string name, string lastname, int yearOfRegistration)
    {
        this.id = id;
        this.name = name;
        this.lastname = lastname;
        this.yearOfRegistration = yearOfRegistration;
    }

    public string denomination(string name, string lastname)
    {
        string result = $"{name} {lastname}";
        return result;
    }
}

public class Book
{
    private string id;
    private string title;
    private string author;
    private string Utente;

    public Book(string id, string title, string author, string Utente)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.Utente = Utente.denomination;
    }

    public Book(string id, string title, string author)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.Utente = null;
    }


}

