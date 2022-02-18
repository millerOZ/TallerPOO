namespace tallerPOO
{
    public class VariablePriceProduct : Product
    {
        public float Quantity { get; set; }
        public string Measurement { get; set; } //medicion

        public override string? ToString()
        {
            return $"{Id}" +
               $"{Description} " +
               $"Measurement: {Measurement}, " +
               $"Quantity: {Quantity}, " +
               $"Price: {Price}, " +
               $"Tax: {Tax}, " +
               $"Value: {ValueToPay()}";
        }

        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
