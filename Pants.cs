namespace SelfService
{
    public class Pants : Apparel
    {
        private static int totalPants;
        public Pants(string type, string brand, string size, double price, int stock)
        {
            this.type = type;
            this.brand = brand;
            this.size = size;
            this.price = price;
            this.stock = stock;
            totalPants++;
            totalpcs++;
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3} | {4}",
                    this.type, this.brand, this.size, this.price, this.stock);
        }

        public static new int Total()
        {
            return totalPants;
        }
    }
}