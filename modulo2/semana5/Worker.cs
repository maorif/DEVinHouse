#nullable disable

public class Ex5
{
    public void Test(){
        
        var worker1 = new Worker("Maori worker", "Floripa", "88888-9999", 12, 3000.0, 0.05, 12000.00, 0.10);
        var wage1 = worker1.CalculateWage();

        Console.WriteLine($"Employee: {worker1.name}\nAdress: {worker1.adress}\nSector {worker1.sectorNumber}\nBase Wage: {worker1.baseWage}\nTax: {worker1.taxPercentage}\nProduction Value: {worker1.productionValue}\nComission: {worker1.comission*100}%\nWage: {wage1}");
    }
}
public class Worker : Employee
{
    public double productionValue { get; private set; }
    public double comission { get; private set; }

    public Worker(
        string name,
        string adress,
        string phone,
        int sectorNumber,
        double baseWage,
        double taxPercentage, 
        double productionValue, 
        double comission) : base(name, adress, phone, sectorNumber, baseWage, taxPercentage)
    {
            this.productionValue = productionValue;
            this.comission = comission;
    }

    public override double CalculateWage()
    {
        return base.CalculateWage() + (productionValue * comission);
    }
}