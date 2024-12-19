
namespace BibloLibrary
{
    public class Utente
    {
        //inizializzazione  parametri con auto-implemented properties
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfRegistration { get; set; }

        //costruttore di default
        public Utente() { }

        public string Denomination()
        {
            return Name + " " + LastName;
        }
    }

    public class Book
    {
        private string id;
        private string title;
        private string author;
        //oggetto della classe utente che può essere nullo 
        private Utente? utente;


        public Book(string id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.utente = null;
        }
        public string Description()
        {
            return this.title + " di " + this.author;
        }

        public void Loan(Utente utente)
        {
            if (this.utente != null)
            {
                Console.WriteLine($"{this.title} è gia in prestito a {this.utente.Denomination()}");
                return;
            }
            else
            {
                this.utente = utente;
                Console.WriteLine($"{this.title} è stato prestato a {this.utente.Denomination()}");
            }

        }
        public void Refund()
        {
            if (this.utente != null)
            {
                Console.WriteLine($"{this.title} è stato restituito da {this.utente.Denomination()}");
                this.utente = null;
            }


        }


    }

    public class LybraryBook
    {

        public static void Main(string[] args)
        {
            //creiamo il primo utente
            Utente utente1 = new Utente("001", "Mario", "Mario", 2021);
            Console.WriteLine(utente1.Denomination());
            // creiamo il secondo Utente
            Utente utente2 = new Utente("001", "Luigi", "Mario", 2020);
            Console.WriteLine(utente2.Denomination());
            // creiamo un Libbro
            Book book = new Book("B01", "Lo Hobbit", "J.R.R.Tolkien");
            Console.WriteLine(book.Description());

            //presto per la prima volta il libbro
            book.Loan(utente1);
            //testo se è possibile prestare il libbro se è già in prestito
            book.Loan(utente2);
            //restituisco il libbro
            book.Refund();
            //presto il libbro ad un nuovo utente
            book.Loan(utente2);

        }
    }



}