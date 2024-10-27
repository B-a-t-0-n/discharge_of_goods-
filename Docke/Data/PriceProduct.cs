namespace DockeLib.Data
{
    public class PriceProduct
    {
        public string? vendor { get; set; }
        public IEnumerable<Cost>? prices { get; set; }
    }
}
