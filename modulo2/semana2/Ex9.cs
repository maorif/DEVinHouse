#nullable disable

public class Ex9 {

    public void Pizza() {

        string[] pizzas = {"mussarela", "calabresa", "portugesa"};
        int slicesEaten = 0;
        int num = -1;
        string input;
        bool parseSuccess;

        Console.WriteLine("Bem vindo ao rodízio de pizzas!");
        
        while(num != 0){

            Console.Write("Escolha uma fatia entre os sabores: \n" + $"1 {pizzas[0]}\n" + $"2 {pizzas[1]} \n" + $"3 {pizzas[2]} \n" + "0 Se estiver satisfeito \n");

            input = Console.ReadLine();
            (num, parseSuccess) = CheckIfInputIsInt(input);

            while(num < 0 || num > 3 || !parseSuccess){
                Console.WriteLine("Digite um número válido!");
                Console.Write($"1 {pizzas[0]}\n" + $"2 {pizzas[1]} \n" + $"3 {pizzas[2]} \n" + "0 Se estiver satisfeito \n");
                input = Console.ReadLine();
                (num, parseSuccess) = CheckIfInputIsInt(input);
            };

            if(num != 0){
                Console.WriteLine($"Você escolheu o sabor {pizzas[num-1]}. \n");
                slicesEaten++;
            };
        };

        Console.WriteLine($"Vocẽ comeu {slicesEaten} fatias de pizza. Volte sempre!");

        //Checks if input is int and return number success status
        (int, bool) CheckIfInputIsInt(string inputNumber){
        
            int num;
            bool parseSuccess = int.TryParse(inputNumber, out num);

            return (num, parseSuccess);
        };
    }
};