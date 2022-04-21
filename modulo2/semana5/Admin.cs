#nullable disable

public class Ex4
{
    public void Test(){
        var admin1 = new Admin("Maori", "Floripa", "88888-9999", 12, 3000.0, 0.10, 500.0);
        var wage1 = admin1.CalculateWage();

        Console.WriteLine($"admin: {admin1.name}\nAdress: {admin1.adress}\n"
            + $"Sector {admin1.sectorNumber}\nBase Wage: {admin1.baseWage}\nTax: {admin1.taxPercentage}\nExpense allowance: {admin1.expenseAllowance}\nWage: {wage1}");
    }
}
public class Admin : Employee
{
    public double expenseAllowance { get; private set; }

    public Admin(string name,
        string adress,
        string phone,
        int sectorNumber,
        double baseWage,
        double taxPercentage,
        double expenseAllowance) : base(name, adress, phone, sectorNumber, baseWage, taxPercentage){
            this.expenseAllowance = expenseAllowance;
    }

    public override double CalculateWage(){

        return base.CalculateWage() + expenseAllowance;
    }
}