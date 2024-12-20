
namespace BibloLibrary
{
    //classe base
    public class Person
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        //denominatio non è più un metodo  ma una variabile in sola lettura
        public string Denomination
        {
            get
            {
                return Name + " " + LastName;
            }
        }

        public Person(string Name, string LastName)
        {
            this.Name = Name;
            this.LastName = LastName;
        }
    }
    //User  diventa una sottoclasse di Person
    public class User : Person
    {
        //inizializzazione  parametri con auto-implemented properties
        //il ? serve per accetare  che la variabile possa essere nulla se ti tipo reference
        public string? ID { get; set; }
        public int YearOfRegistration { get; set; }

        public User(string ID, int YearOfRegistration, string Name, string LastName) : base(Name, LastName)
        {
            this.ID = ID;
            this.YearOfRegistration = YearOfRegistration;
        }

    }

    public class Book
    {
        private string? id;
        private string? title;
        private string? author;
        //oggetto della classe utente che può essere nullo 
        private User? utente;


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

        public void Loan(User utente)
        {
            if (this.utente != null)
            {
                Console.WriteLine($"{this.title} è gia in prestito a {this.utente.Denomination}");
                return;
            }
            else
            {
                this.utente = utente;
                Console.WriteLine($"{this.title} è stato prestato a {this.utente.Denomination}");
            }

        }
        public void Refund()
        {
            if (this.utente != null)
            {
                Console.WriteLine($"{this.title} è stato restituito da {this.utente.Denomination}");
                this.utente = null;
            }


        }


    }
    public class LybraryBook
    {

        public static void Main(string[] args)
        {
            //creiamo il primo utente
            User user1 = new User("001", 2021, "Mario", "Mario");
            Console.WriteLine(user1.Denomination);

            User user2 = new User("002", 2020, "Luigi", "Mario");
            Console.WriteLine(user2.Denomination);
            // creiamo un Libro
            Book book = new Book("B01", "Lo Hobbit", "J.R.R.Tolkien");
            Console.WriteLine(book.Description());

            //presto per la prima volta il libro
            book.Loan(user1);
            //testo se è possibile prestare il libbro se è già in prestito
            book.Loan(user2);
            //restituisco il libro
            book.Refund();
            //presto il libro ad un nuovo utente
            book.Loan(user2);

        }
    }



}