#nullable disable

namespace Ex9
{
    public enum SpecieEnum{
        Cat, Dog, Fish
    }

    public class Animal
    {
        public string name { get; private set; }

        public SpecieEnum specie { get; private set; }

        public Animal(string name, SpecieEnum specie, AnimalList animalList){
            this.name = name;
            this.specie = specie;

            animalList.AddToAnimalList(this);
        }
        
        public bool CheckSpecie(SpecieEnum specie){

            if(specie == this.specie){
                return true;
            }
            else{
                return false;
            }
        }
    }

    public class AnimalList
    {
        public List<Animal> list { get; private set; }

        public void AddToAnimalList(Animal animal){

            if(list is null){
                list = new List<Animal>();
            }

            list.Add(animal);
        }

        public int CheckNumOfDogs(){

            var num = list.Count(animal => animal.specie == SpecieEnum.Dog);

            return num;
        }
    }
}