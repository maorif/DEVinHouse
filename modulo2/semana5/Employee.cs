#nullable disable

//Ex 3
public class Ex3
{
    public void Test(){
        
        var employee1 = new Employee("Maori", "Floripa", "88888-9999", 12, 3000.0, 0.05);
        var wage1 = employee1.CalculateWage();

        Console.WriteLine($"Employee: {employee1.name}\nAdress: {employee1.adress}\n"
            + $"Sector {employee1.sectorNumber}\nWage: {wage1}");
    }
}
public class Employee : Person
{
    public int sectorNumber { get; private set; }
    public double baseWage { get; private set; }
    public double taxPercentage { get; private set; }

    public Employee(
        string name,
        string adress,
        string phone,
        int sectorNumber,
        double baseWage,
        double taxPercentage) : base(name, adress, phone){
            this.sectorNumber = sectorNumber;
            this.baseWage = baseWage;
            this.taxPercentage = taxPercentage;
        }

    public virtual double CalculateWage(){

        return baseWage - (baseWage * taxPercentage);
    }
}