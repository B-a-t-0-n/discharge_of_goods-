using Microsoft.Office.Interop.Excel;
using GrandLineLib.Data;

namespace GrandLineLib
{
    public class GrandLineTableExel
    {
        public List<Product> Products { get; set; }
        public readonly GrandLine grandLine;

        public GrandLineTableExel(GrandLine grandLine) 
        {
            Products = new List<Product>();
            this.grandLine = grandLine;
        }

        public void UpdateProducts()
        {
            for (int i = 0; i < grandLine.Prices!.Count; i++)
            {

            }
        }

        public void CreateTable(string savePath)
        {

        }
    }
}
