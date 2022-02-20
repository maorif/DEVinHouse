#nullable disable

//Exercício 8: Fatorial

public class Ex8 {

    public void Factorial() {

        Console.WriteLine("Digite um número de 0 a 10:");
    
        var input = Console.ReadLine();
        (int num, bool parseSuccess) = CheckIfInputIsInt(input);

        while(num < 0 || num > 10 || !parseSuccess){
            Console.WriteLine("Digite o número corretamente (0 a 10):");
            input = Console.ReadLine();
            (num, parseSuccess) = CheckIfInputIsInt(input);
        };

        int numFatorial;

        if(num == 0){
            numFatorial = 1;
        }
        else{
            numFatorial = num;
            for(int i = num-1; i > 0; i--){
                numFatorial *= i;
            };
        };

        Console.WriteLine($"O fatorial deste número é: {numFatorial}");


        //Checks if input is int and return number success status
        (int, bool) CheckIfInputIsInt(string inputNumber){
        
            int num;
            bool parseSuccess = int.TryParse(inputNumber, out num);

            return (num, parseSuccess);
        };
    }
};
