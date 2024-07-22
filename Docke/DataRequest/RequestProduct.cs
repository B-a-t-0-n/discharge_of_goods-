using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockeLib.DataRequest
{
    public class RequestProduct
    {
        public string? agree_uuid { get; set; }
        public string? factory_uuid { get; set; }
        public int? offset { get; set; }
        public int? page { get; set; }
        public bool? can_buy { get; set; }
    }
}
