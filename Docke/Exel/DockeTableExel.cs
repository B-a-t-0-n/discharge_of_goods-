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
            Products = docke.Products!.GroupJoin(docke.Prices!,
                                                  i => i.vendor,
                                                  j => j.vendor,
                                                  (i, jGroup) => new { i, jGroup })
                                                    .SelectMany(
                                                        x => x.jGroup.DefaultIfEmpty(),
                                                        (x, j) => new ProductExel()
                                                        {
                                                            Vendor = x.i.vendor,
                                                            Name = x.i.nomenclature,
                                                            Price = j != null ? j.price : 0,
                                                            Measure = j != null ? j.measureName : ""
                                                        }
                                                    ).ToList();

            Products = Products.GroupJoin(docke.PricesRRP!,
                                           i => i.Vendor,
                                           j => j.vendor,
                                           (i, jGroup) => new { i, jGroup })
                                                .SelectMany(
                                                    x => x.jGroup.DefaultIfEmpty(),
                                                    (x, j) => new ProductExel()
                                                    {
                                                        Vendor = x.i.Vendor,
                                                        Name = x.i.Name,
                                                        Price = x.i.Price,
                                                        RRCPrice = j != null ? j.price : 0,
                                                        Measure = x.i.Measure
                                                    }
                                                ).ToList();

           
        }

        public void CreateTable(string filePath)
        {
            ExcelUtility.SaveToExcel(ConvertToMatrixProduct(Products), filePath);
        }

        private string[,] ConvertToMatrixProduct(List<ProductExel> products)
        {
            string[,] pr = new string[products.Count + 1, 5];

            pr[0, 0] = "Артикул";
            pr[0, 1] = "Название";
            pr[0, 2] = "Закупочные цены";
            pr[0, 3] = "РЦЦ цены";
            pr[0, 4] = "Ед. измерения";

            for (int i = 1; i <= products.Count; i++)
            {
                pr[i, 0] = products[i - 1].Vendor!;
                pr[i, 1] = products[i - 1].Name!;
                pr[i, 2] = $"{products[i - 1].Price!}".Replace('.', ',');
                pr[i, 3] = $"{products[i - 1].RRCPrice!}".Replace('.', ',');
                pr[i, 4] = products[i - 1].Measure!;
            }

            return pr;
        }
    }
}
