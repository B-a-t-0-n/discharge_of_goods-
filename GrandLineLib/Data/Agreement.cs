namespace GrandLineLib.Data
{
    public class Agreement
    {
        public string id_1c { get; set; } = "";
        public string code_1c { get; set; } = "";
        public string name { get; set; } = "";
        public Contractor? contractor { get; set; }
        public IEnumerable<AdditionalAgreement>? additional_agreements { get; set; }
        
        public override string ToString()
        {
            return $"{id_1c}\n{code_1c}\n{name}\n{contractor}\n{string.Join(' ',additional_agreements!)}";
        }
    }
}
