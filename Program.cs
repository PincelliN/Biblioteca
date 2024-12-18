// See https://aka.ms/new-console-template for more information
class User
{
    private string id;
    private string name;
    private string lastname;
    private int yearOfRegistration;

    public User(string id, string name, string lastname, int yearOfRegistration)
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
