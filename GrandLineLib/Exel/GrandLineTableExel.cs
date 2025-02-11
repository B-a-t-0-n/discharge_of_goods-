﻿using Exel;
using GrandLineLib.Data;

namespace GrandLineLib.Exel
{
    public class GrandLineTableExel 
    {
        public List<ProductExel> Products { get; set; }
        public readonly GrandLine grandLine;

        public GrandLineTableExel(GrandLine grandLine)
        {
            Products = new List<ProductExel>();
            this.grandLine = grandLine;
            UpdateProducts();
        }

        public void UpdateProducts()
        {
            Products = grandLine.Nomenclatures!.Join(grandLine.Prices!,
                                                  i => i.id_1c,
                                                  j => j.nomenclature_id,
                                                  (i, j) => new ProductExel()
                                                  {
                                                      Code1C = i.code_1c,
                                                      Name = i.full_name,
                                                      Price = j.price,
                                                      Discount = j.discount,
                                                      DiscountPrice = j.discountPrice,
                                                      Measure = i.quantity_unit.name
                                                  }).ToList();
        }

        public void CreateTable(string filePath)
        {
            ExcelUtility.SaveToExcel(ConvertToMatrixProduct(Products), filePath);
        }

        private string[,] ConvertToMatrixProduct(List<ProductExel> products)
        {
            string[,] pr = new string[products.Count + 1, 6];

            pr[0, 0] = "код 1с";
            pr[0, 1] = "название";
            pr[0, 2] = "прайс";
            pr[0, 3] = "скидка";
            pr[0, 4] = "цена со скидкой";
            pr[0, 5] = "Ед. измерения";

            for (int i = 1; i <= products.Count; i++)
            {
                pr[i, 0] = products[i - 1].Code1C;
                pr[i, 1] = products[i - 1].Name;
                pr[i, 2] = products[i - 1].Price.Replace('.',',');
                pr[i, 3] = products[i - 1].Discount.Replace('.', ',');
                pr[i, 4] = products[i - 1].DiscountPrice.Replace('.', ',');
                pr[i, 5] = products[i - 1].Measure;

            }

            return pr;
        }

    }
}
