#nullable disable

//Exercício 3: Nome completo
public class Ex3 {

    public void WriteCompleteName(){

        Console.WriteLine("Qual seu primeiro nome?");
        string name = Console.ReadLine();

        Console.WriteLine("Qual seu sobrenome nome?");
        string surName = Console.ReadLine();

        Console.WriteLine($"Bem vindo(a) {name} {surName}");

        Console.Write("\n ---------------------------- \n \n");
    }

};