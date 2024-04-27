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
                                                  i => i.code_1c,
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
            string[,] pr = new string[products.Count + 1, 5];

            pr[0, 0] = "код 1с";
            pr[0, 1] = "название";
            pr[0, 2] = "прайс";
            pr[0, 3] = "скидка";
            pr[0, 4] = "цена со скидкой";

            for (int i = 1; i <= products.Count; i++)
            {
                pr[i, 0] = products[i - 1].Code1C;
                pr[i, 1] = products[i - 1].Name;
                pr[i, 2] = products[i - 1].Price;
                pr[i, 3] = products[i - 1].Discount;
                pr[i, 4] = products[i - 1].DiscountPrice;
            }

            return pr;
        }

    }
}
