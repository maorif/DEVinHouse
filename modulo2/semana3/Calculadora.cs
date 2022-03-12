#nullable disable

namespace Ex5
{

    public class Calculadora{

        public double value1 { get; set; }
        public double value2 { get; set; }

        public string op { get; set; }

        public void Calculator(){
            
            Console.WriteLine("Digite o 1º valor");
            value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor");
            value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a operação a ser feita entre as opções:\nSoma: '+'\nSubtração: '-'\nMultiplicação: '*'\nDivisão: '/'");

            op = Console.ReadLine();
            

            while(op != "+" && op != "-" && op != "*" && op != "/"){
                Console.WriteLine("Digite um operador válido!");
                op = Console.ReadLine();
                
            }

            Console.WriteLine($"Operação: {value1} {op} {value2}");
            Calculate();
        }

        public void Calculate(){

            if(op == "+"){
                var result = value1 + value2;
                Console.WriteLine($"O resultado é: {result}");
            }
            if(op == "-"){
                var result = value1 - value2;
                Console.WriteLine($"O resultado é: {result}");
            }
            if(op == "*"){
                var result = value1 * value2;
                Console.WriteLine($"O resultado é: {result}");
            }
            if(op == "/"){
                var result = value1 / value2;
                Console.WriteLine($"O resultado é: {result}");
            }
        }
    }
}