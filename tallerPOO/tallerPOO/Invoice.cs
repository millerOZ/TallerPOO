namespace tallerPOO
{
    public class Invoice : IPay
    {
        public List<Product> Products { get; set; }
        public void AddProduct(Product product) { }
        public Invoice() { }

        public decimal ValueToPay()
        {
            return 000000;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
