#nullable disable

//Exercício 6: Invertendo strings
public class Ex6 {

    public void InvertingStrings() {

        Console.WriteLine("Digite seu nome:");
        string name = Console.ReadLine();
        string invertedName = new string(name.Reverse().ToArray());
        Console.WriteLine(invertedName);

        Console.Write("\n ---------------------------- \n \n");
    } 
};
