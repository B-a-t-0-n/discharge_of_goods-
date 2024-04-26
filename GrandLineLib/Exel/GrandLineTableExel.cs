using Exel = Microsoft.Office.Interop.Excel;
using GrandLineLib.Data;
using Microsoft.Office.Interop.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrandLineLib.Exel
{
    public class GrandLineTableExel 
    {
        public List<Product> Products { get; set; }
        public readonly GrandLine grandLine;
        private string? _filePath;

        public GrandLineTableExel(GrandLine grandLine)
        {
            Products = new List<Product>();
            this.grandLine = grandLine;
            UpdateProducts();
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

        public void CreateTable(string filePath)
        {
            ExcelUtility.SaveToExcel(ConvertToMatrixProduct(Products), filePath);
        }

        private string[,] ConvertToMatrixProduct(List<Product> products)
        {
            string[,] pr = new string[products.Count, 5];

            for (int i = 0; i < products.Count; i++)
            {
                pr[i, 0] = products[i].Code1C;
                pr[i, 1] = products[i].Name;
                pr[i, 2] = products[i].Price;
                pr[i, 3] = products[i].Discount;
                pr[i, 4] = products[i].DiscountPrice;
            }

            return pr;
        }

    }
}
