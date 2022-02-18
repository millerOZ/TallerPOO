namespace tallerPOO
{
    public class Invoice : IPay
    {
        public List<Product> Products { get; set; }
        public void AddProduct() { }
        public Invoice() { }
        public override string ToString()
        {
            return base.ToString();
        }
        public decimal ValueToPay() { return base.}
    }
}
