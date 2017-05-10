namespace BetaBit.DesignPatterns
{
    public sealed class ProductType
    {
        public string Name { get; }
        public bool IsDigital { get; }

        private ProductType(string name, bool isDigital)
        {
            Name = name;
            IsDigital = isDigital;
        }

        public static ProductType Book { get; } = new ProductType("Dead Tree Book", false);
        public static ProductType Ebook { get; } = new ProductType("Electric Book", true);
        public static ProductType Software { get; } = new ProductType("Software", true);
    }
}
