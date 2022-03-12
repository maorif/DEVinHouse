#nullable disable

namespace Ex4 {

    public class Pessoa {

        private string _name;

        private int _age;

        public string Name { get{return _name; } set{ _name = value; }}
        public int Age { get{ return _age; } set{ _age = value; }}

        public void GetInfo(){

            Console.WriteLine($"Nome: {_name} \nIdade: {_age}\n\n");
        }
    }

    public class WhoIsOlder{

        public void AskUser(){

            Console.WriteLine("Escreva o nome da primeira pessoa:");
            var Pessoa1 = new Pessoa();
            Pessoa1.Name = Console.ReadLine();

            Console.WriteLine("Escreva a idade da primeira pessoa:");
            Pessoa1.Age = int.Parse(Console.ReadLine());

            Pessoa1.GetInfo();


            Console.WriteLine("Escreva o nome da segunda pessoa:");
            var Pessoa2 = new Pessoa();
            Pessoa2.Name = Console.ReadLine();

            Console.WriteLine("Escreva a idade da segunda pessoa:");
            Pessoa2.Age = int.Parse(Console.ReadLine());

            Pessoa2.GetInfo();

            if(Pessoa1.Age > Pessoa2.Age){
                Console.WriteLine($"A pessoa mais velha é {Pessoa1.Name}");
            }
            else {
                Console.WriteLine($"A pessoa mais velha é {Pessoa2.Name}");
            }
        }
    }
    
}