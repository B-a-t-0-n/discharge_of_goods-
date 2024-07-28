using DockeLib.Exel.Data;
using Exel;

namespace DockeLib.Exel
{
    public class DockeTableExel
    {
        public List<ProductExel> Products { get; set; }
        public readonly Docke docke;

        public DockeTableExel(Docke docke)
        {
            Products = new List<ProductExel>();
            this.docke = docke;
            UpdateProducts();
        }

        public void UpdateProducts()
        {
            Products = docke.Products!.Join(docke.Prices!,
                                                  i => i.vendor,
                                                  j => j.vendor,
                                                  (i, j) => new ProductExel()
                                                  {
                                                      Vendor = i.vendor,
                                                      Name = i.nomenclature,
                                                      Price = j.price
                                                  }).ToList();

            Products = Products.Join(docke.PricesRRP,
                                           i => i.Vendor,
                                           j => j.vendor,
                                           (i, j) => new ProductExel()
                                           {
                                               Vendor = i.Vendor,
                                               Name = i.Name,
                                               Price = i.Price,
                                               RRCPrice = j.price
                                           }).ToList();
                                                  
        }

        public void CreateTable(string filePath)
        {
            ExcelUtility.SaveToExcel(ConvertToMatrixProduct(Products), filePath);
        }

        private string[,] ConvertToMatrixProduct(List<ProductExel> products)
        {
            string[,] pr = new string[products.Count + 1, 4];

            pr[0, 0] = "Артикул";
            pr[0, 1] = "Название";
            pr[0, 2] = "Закупочные цены";
            pr[0, 3] = "РЦЦ цены";

            for (int i = 1; i <= products.Count; i++)
            {
                pr[i, 0] = products[i - 1].Vendor!;
                pr[i, 1] = products[i - 1].Name!;
                pr[i, 2] = $"{products[i - 1].Price!}".Replace('.', ',');
                pr[i, 3] = $"{products[i - 1].RRCPrice!}".Replace('.', ',');
            }

            return pr;
        }
    }
}
