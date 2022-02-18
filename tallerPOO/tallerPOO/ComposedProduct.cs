namespace tallerPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
