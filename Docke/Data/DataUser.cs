using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockeLib.Data
{
    public class DataUser
    {
        public string? token { get; set; }
        public List<Agrees>? agrees { get; set; }
        public List<Contragents>? contragent { get; set; }
        public List<Factories>? factories { get; set; }
    }
}
