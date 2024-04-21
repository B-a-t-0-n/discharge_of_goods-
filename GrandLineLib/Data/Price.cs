namespace GrandLineLib.Data
{
    public class Price
    {
        public string nomenclature_id { get; set; } = "";
        public string price { get; set; } = "";
        public string discount { get; set; } = "";
        public string discountPrice { get; set; } = "";

        public override string ToString()
        {
            return $"{nomenclature_id}\n{price}\n" +
                   $"{discount}\n{discountPrice}";
        }

    }
}
