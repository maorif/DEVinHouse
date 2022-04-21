#nullable disable

// Ex 2
public class Ex2
{
    public void Test(){
        var provider1 = new Provider(1450.50, 1200.00);
        var balance1 = provider1.GetBalance();
        Console.WriteLine(balance1);
        Console.WriteLine("-------------------------");

        var provider2 = new Provider("Maori", "Florianópolis", "99999-8888", 2500.0, 3000.0);
        var balance2 = provider2.GetBalance();
        Console.WriteLine($"Name: {provider2.name}\nAdress: {provider2.adress}\nPhone: {provider2.phone}\nBalance: {balance2}");
    }       
}

public class Provider : Person
{
    public double credit { get; private set; }
    public double debit { get; private set; }

    public Provider() {
        this.credit = 0.0;
        this.debit = 0.0;
    }
    public Provider(double credit, double debit) {
        this.credit = credit;
        this.debit = debit;
    }

    public Provider(
        string name, 
        string adress, 
        string phone, 
        double credit, 
        double debit) : base(name, adress, phone){
            this.credit = credit;
            this.debit = debit;
    }

    public double GetBalance(){

        var balance = credit - debit;
        return balance;
    }
}