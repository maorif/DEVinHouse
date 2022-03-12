#nullable disable

namespace Ex3 {

    public class Retangulo {

        public double side1 { get; set; }

        public double side2 { get; set; }

        public double area { get; set; }

        public void Area(){
            area = Math.Round(side1*side2, 2);
        }

        public void ShowArea(){
            Console.WriteLine($"Área: {area}");
        }

        public void ShowData(){

            Console.WriteLine($"Lado 1: {side1}, Lado 2: {side2}, Área: {Area}");
        }

        public void AskSides(){

            Console.WriteLine("Digite o lado 1 do retângulo:");
            side1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o lado 2 do retângulo:");
            side2 = double.Parse(Console.ReadLine());

            Area();

            Console.WriteLine($"A área do retãngulo é: {area}");

        }
    }
}