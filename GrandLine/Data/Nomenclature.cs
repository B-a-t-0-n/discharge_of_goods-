using System.ComponentModel.DataAnnotations.Schema;

namespace GrandLine.Data
{
    public class Nomenclature
    {
        public string id_1c { get; set; } = "";
        public string code_1c { get; set; } = "";
        public string full_name { get; set; } = "";
        public SizeUnit? size_unit { get; set; }  
        public AmountUnit? amount_unit { get; set; }
        public QuantityUnit? quantity_unit { get; set; }
        public string type_size_id { get; set; } = "";
        public string tnved { get; set; } = "";
        public string color { get; set; } = "";
        public string thickness { get; set; } = "";
        public string foil { get; set; } = "";
        public string surface { get; set; } = "";
        public string weight { get; set; } = "";
        public string nomenclature_kind { get; set; } = "";
        public IEnumerable<AddAmountUnits>? add_amount_units { get; set; }

        public override string ToString()
        {
            return $"{id_1c}\n{code_1c}\n{full_name}\n{size_unit}\n{amount_unit}\n{quantity_unit}\n{type_size_id}\n"+
                   $"{tnved}\n{color}\n{thickness}\n{foil}\n{surface}\n{weight}\n{nomenclature_kind}\n"+
                   $"{string.Join(' ',add_amount_units)}";
        }
    }
}
