using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandLine.Data
{
    public class QuantityUnit
    {
        public string id_1c { get; set; } = "";
        public string name { get; set; } = "";

        public override string ToString()
        {
            return $"{id_1c} {name}";
        }
    }
}
