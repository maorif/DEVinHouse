#nullable disable

//Exercício 5: Arredondando números
public class Ex5 {

    public void RoudingNumbers(){
        Console.WriteLine("Digite um número com duas casas decimais (exemplo 3.41):");

    decimal num = decimal.Parse(Console.ReadLine());
    Console.WriteLine(num);

    while(num.ToString().Length < 4 || Decimal.Round(num, 2) != num){
        Console.WriteLine("Por favor digite o número corretamente com duas casas decimais!");

        num = decimal.Parse(Console.ReadLine());
    }
    
    Console.WriteLine($"Arrendodando {num} -> {Math.Round(num)}");

    Console.Write("\n ---------------------------- \n \n");    
    }
};