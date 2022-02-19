namespace tallerPOO
{
    public class VariablePriceProduct : Product
    {
        public float Quantity { get; set; }
        public string Measurement { get; set; } //medicion


        public override decimal ValueToPay()
        {
            decimal total = Price * (decimal)Quantity;
            return total  + (total * (decimal)Tax); 
        }
        public override string? ToString()
        {
            return $"{Id}" +
               $"\t{Description} " +
               $"\n\tMeasurement.........: {$"{Measurement}",15}, " +
               $"\n\tQuantity............: {$"{Quantity:C2}",15}, " +
               $"\n\tPrice...............: {$"{Price:C2}",15}, " +
               $"\n\tTax.................: {$"{Tax:P2}",15}, " +
               $"\n\tValue...............: {$"{ValueToPay():C2}",15}";
        }
    }
}
