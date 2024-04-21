namespace GrandLineLib.Data
{
    public class Contractor
    {
        public string id_1c { get; set; } = "";
        public string code_1c { get; set; } = "";

        public override string ToString()
        {
            return $"{id_1c} {code_1c}";
        }
    }
}
