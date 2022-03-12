#nullable disable

namespace Ex1 {

    public class Person {
        
        private string _name;
        private DateOnly _birthDate;
        private int _height; //cm

        public string Name { get => _name;  set => _name = value; }
        public DateOnly BirthDate { get => _birthDate;  set => _birthDate = value; }
        public int Height { get => _height;  set => _height = value; }

        public string showPersonData(){

            return $"Nome: {Name} \nData de Nascimento: {BirthDate} \nAltura: {Height}";   
        }

    }
};