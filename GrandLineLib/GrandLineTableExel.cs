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
            Products = grandLine.Nomenclatures!.Join(grandLine.Prices!,
                                                  i => i.id_1c,
                                                  j => j.nomenclature_id,
                                                  (i, j) => new Product()
                                                  {
                                                      Code1C = i.code_1c,
                                                      Name = i.full_name,
                                                      Price = j.price,
                                                      Discount = j.discount,
                                                      DiscountPrice = j.discountPrice
                                                  }).ToList();
        }

        public void CreateTable(string savePath)
        {

        }
    }
}
