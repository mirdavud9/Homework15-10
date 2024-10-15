using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._10
{
    internal class ProductApp
    {
        public class Product
        {
            public string Id;
            public string BrandName;
            public string Model;
            public decimal Price;
            public decimal Cost;
            public decimal Income;
            public int Count;
            public Product(string brandName, string model, decimal price, decimal cost, int count)
            {
                BrandName = brandName;
                Model = model;
                Price = price;
                Cost = cost;
                Count = count;

                Id = $"{BrandName.Substring(0, 2)}{Model.Substring(0, 2)}";
            }

            public void GetInfo()
            {
                Console.WriteLine($"ID: {Id}, Marka: {BrandName}, Model: {Model}, Qiymet: {Price}, Xercler: {Cost}, Say: {Count}, Gəlir: {Income}");
            }
            public void Sale(int quantity)
            {
                if (Count >= quantity)
                {
                    Count -= quantity;
                    decimal saleIncome = (Price - Cost) * quantity;
                    Income += saleIncome;
                    Console.WriteLine($"{quantity} qeder mehsul satildi. Gelir: {saleIncome} ₼");
                }
                else
                {
                    Console.WriteLine("Kifayet qeder mehsul yoxdur.");
                }
            }
        }
    }
}
