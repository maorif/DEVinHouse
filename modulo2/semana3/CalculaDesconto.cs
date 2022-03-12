#nullable disable

namespace Ex10
{
    public class Product
    {
        public string name { get; private set; }
        public double value { get; private set; }
        public double discount { get; private set; }

        public Product(string name, double value){
            this.name = name;
            this.value = value;
            this.discount = 0.0;
        }

        public Product(string name, double value, double discount){
            this.name = name;
            this.value = value;
            this.discount = discount;
        }

        public double ReturnDiscount(){

            return this.discount*100;
        }
    }

    public class CheckProduct
    {
        public void PriceWithDiscount(Product product){

            var price = product.value - (product.value * product.discount);

            Console.WriteLine($"Product: {product.name}\nPrice: {product.value}\nPrice with Discount: {price}");
        }
    }
}