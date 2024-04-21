using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandLine.Data
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
            return $"{id_1c}\n{code_1c}\n{name}\n{contractor}\n{additional_agreements}";
        }
    }
}
