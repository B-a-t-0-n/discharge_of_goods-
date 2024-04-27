namespace GrandLineLib.Data
{
    public class Branche
    {
        public string id_1c { get; set; } = "";
        public string code_1c { get; set; } = "";
        public string name { get; set; } = "";
        public string address { get; set; } = "";
        public string description { get; set; } = "";
        
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
