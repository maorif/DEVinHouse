#nullable disable

public class Ex11 {

    public void UserTypeArray() {
        
        Console.WriteLine("Digite quantos números deseja no array:");
        var input = Console.ReadLine();
        (int num, bool parseSuccess) = CheckIfInputIsInt(input);

        while(num <= 0 || !parseSuccess){
                Console.WriteLine("Digite um número válido maior que 0!");
                input = Console.ReadLine();
                (num, parseSuccess) = CheckIfInputIsInt(input);
        };

        string[] userArray = new string[num];
        for(int i=0; i<num; i++){
            Console.WriteLine($"Digite o elemento número {i+1} do array:");
            userArray[i] = Console.ReadLine();
        };

        Console.Write("O seu array invertido: (");
        for(int j=num; j>0; j--){
            if(j == 1){
                Console.Write(userArray[j-1] + ")\n");
            }
            else{
                Console.Write(userArray[j-1] + ", ");
            }
            
        };
        
        //Checks if input is int and return number success status
        (int, bool) CheckIfInputIsInt(string inputNumber){
        
            int num;
            bool parseSuccess = int.TryParse(inputNumber, out num);

            return (num, parseSuccess);
        };
    }
};