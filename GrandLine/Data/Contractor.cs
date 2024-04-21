using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GrandLine.Data
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
