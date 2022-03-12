#nullable disable

namespace Ex2 {

    public class Menu {

        private string _dish;
        private List<string> _ingredients;
        private double _price;

        public string Dish { get{ return _dish; }  set{ _dish = value; } }

        public List<string> Ingredients { get{ return _ingredients; } set{ _ingredients = value; }}

        public double Price { get{ return _price; }  set{ _price = value; } }

        public void ShowIngredients() {

            Console.WriteLine("Ingredientes:");
            Console.WriteLine(string.Join(",", Ingredients));
        }
    }
}