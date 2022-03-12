#nullable disable

namespace Ex6
{
    public class Pedido{

        public DateTime date { get; set; }
        public List<Item> itensList;

        public void AddToList(Item item){

            if(itensList is null){
                itensList = new List<Item>();
            }

            itensList.Add(item);
        }

        public int NumItens(){

            return itensList.Count();
        }

        public double TotalValue(){

            return itensList.Sum(item => item.price);
        }
    }

    public class Item{

        public string name { get; set; }
        public double price { get; set; }

        public Item(string itemName, double itemPrice){
            name = itemName;
            price = itemPrice;
        }
    }
}