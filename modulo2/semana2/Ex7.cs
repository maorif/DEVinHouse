#nullable disable

//Exercício 7: Média de notas
public class Ex7 {

    public void Mean() {
        Console.WriteLine("Digite as notas do semestre...");
    
        Console.WriteLine("Digite a primeira nota: ");
        decimal n1 = decimal.Parse(Console.ReadLine());
        n1 = CheckDecimals(n1);
        Console.WriteLine(n1);


        Console.WriteLine("Digite a segunda nota: ");
        decimal n2 = decimal.Parse(Console.ReadLine());
        n2 = CheckDecimals(n2);
        Console.WriteLine(n2);

        Console.WriteLine("Digite a terceira nota: ");
        decimal n3 = decimal.Parse(Console.ReadLine());
        n3 = CheckDecimals(n3);
        Console.WriteLine(n3);


        decimal CheckDecimals(decimal number){

            while(number.ToString().Length < 4 || Decimal.Round(number, 2) != number) {
                Console.WriteLine("Digite a nota corretamente!");
                number = decimal.Parse(Console.ReadLine());
            };

            return number;
        };

        decimal mean = decimal.Round( (n1 + n2 + n3)/3, 2 );
        Console.WriteLine($"Sua media final é: {mean}");

        Console.Write("\n ---------------------------- \n \n");
    }
    
};