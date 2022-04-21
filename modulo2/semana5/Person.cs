#nullable disable

//Ex 1
public class Person
{
    public string name { get; private set; }
    public string adress { get; private set; }
    public string phone { get; private set; }

    public Person() { }

    public Person(string name, string adress){
        this.name = name;
        this.adress = adress;
    }
    
    public Person(string name, string adress, string phone){
        this.name = name;
        this.adress = adress;
        this.phone = phone;
    }
}