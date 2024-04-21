namespace GrandLineLib.Data
{
    public class AmountUnit
    {
        public string id_1c { get; set; } = "";
        public string name { get; set; } = "";
        public float coefficient { get; set; }

        public override string ToString()
        {
            return $"{id_1c} {name} {coefficient}";
        }
    }
}
