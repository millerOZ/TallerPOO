namespace tallerPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal priceAux = 0;
            foreach (var item in Products)
            {
                priceAux += item.ValueToPay();
            }
            return priceAux - priceAux * (decimal)Discount ;
        }
        public override string? ToString()
        {
            return $"{Id}" +
               $"\t{Description} " +
               $"\n\tProducts............: {$"{Products}",15}, " +
               $"\n\tDiscount............: {$"{Discount:P2}",15}, " +
               $"\n\tValue...............: {$"{ValueToPay():C2}",15}";
        }
    }
}
