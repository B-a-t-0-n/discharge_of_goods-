using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockeLib.Data
{
    public class PriceProductRpp
    {
        public string? vendor { get; set; }
        public string? measure { get; set; }
        public dynamic? price { get; set; }
        public string? measureName { get; set; }
    }
}
