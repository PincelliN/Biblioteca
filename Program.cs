// See https://aka.ms/new-console-template for more information

namespace BibloLibrary
{
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

        public string Denomination()
        {
            return this.name + " " + this.lastname;
        }
    }

    public class Book
    {
        private string id;
        private string title;
        private string author;
        //oggetto della classe utente 
        private Utente utente;


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
            Console.WriteLine($"{this.title} è stato restituito da {this.utente.Denomination()}");
            this.utente = null;

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