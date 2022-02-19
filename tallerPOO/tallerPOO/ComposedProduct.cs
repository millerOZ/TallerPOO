namespace tallerPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal priceAux = 0;
            foreach (var product in Products)
            {
                priceAux += product.ValueToPay();
            }
            return priceAux - priceAux * (decimal)Discount ;
        }
        private string _productName()
        {
            string name = "";
            foreach (var product in Products)
            {
                name += product.Description + ", ";
            }
            return name;
        }
        public override string? ToString()
        {   
            
            return $"{Id}" +
               $"\t{Description} " +
               $"\n\tProducts............: {$"{_productName()}",15}, " +
               $"\n\tDiscount............: {$"{Discount:P2}",15}, " +
               $"\n\tValue...............: {$"{ValueToPay():C2}",15}";
        }
    }
}
