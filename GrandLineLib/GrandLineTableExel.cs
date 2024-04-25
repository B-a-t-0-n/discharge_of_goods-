using Exel = Microsoft.Office.Interop.Excel;
using GrandLineLib.Data;
using Microsoft.Office.Interop.Excel;

namespace GrandLineLib
{
    public class GrandLineTableExel : IDisposable
    {
        public List<Product> Products { get; set; }
        public readonly GrandLine grandLine;
        private Application _exel;
        private Workbook? _workbook;
        private string? _filePath;

        public GrandLineTableExel(GrandLine grandLine) 
        {
            Products = new List<Product>();
            this.grandLine = grandLine;
            _exel = new Application();
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
            //try
            //{
                Open(filePath);

                for(int i = 0; i < Products.Count; i++)
                {
                    Set("A", i + 1, Products[i].Code1C);
                    Set("B", i + 1, Products[i].Name);
                    Set("C", i + 1, Products[i].Price);
                    Set("D", i + 1, Products[i].Discount);
                    Set("E", i + 1, Products[i].DiscountPrice);
                }

                Save();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }

        private void Open(string filePath)
        {
            //try
            //{
                if (File.Exists(filePath))
                {
                    _workbook = _exel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _exel.Workbooks.Add();
                    _filePath = filePath;
                }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }

        private void Save() 
        {
            if (string.IsNullOrEmpty(_filePath))
                _workbook.Save();
            else
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
        }

        private void Set(string column, int row, object value)
        {
            //try
            //{
                ((Exel.Worksheet)_exel.ActiveSheet).Cells[row, column] = value;
            //}
            //catch( Exception ex )
            //{
            //    Console.WriteLine(ex);
            //}
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch( Exception ex )
            {
                Console.WriteLine(ex);
            }
        }
    }
}
