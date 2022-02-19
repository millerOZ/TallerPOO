namespace tallerPOO
{
    public class Invoice : IPay
    {
        private List<Product> _products { get; set; }
        public void AddProduct(Product product)
        {   
            if(product != null) {
                _products.Add(product);
            }
        }
        public Invoice() {
            _products = new List<Product>();
        }

        public decimal ValueToPay()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.ValueToPay();
            }
            return total;
        }
        public override string ToString()
        {
            string aux = "";
;            foreach (var product in _products)
            {
                aux += product.ToString() +"\n";
            }
            return "RECEIPT\n"+
            "--------------------------------\n" +
            aux +
           $"\n\tTOTA:                 {$"{ValueToPay():C2}",15}";
        }
    }
}
