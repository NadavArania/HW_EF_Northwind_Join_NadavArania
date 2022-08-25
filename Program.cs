using HW_EF_Northwind_Join.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_EF_Northwind_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //Targil 1
                //var product = db.Products;
                //var query1 = from x in product
                //             select new { ProductName = x.ProductName, Quantity = x.QuantityPerUnit };
                //query1.Distinct().ToList().ForEach(x => Console.WriteLine($"Product Name : {x.ProductName} \nQuantity : {x.Quantity}"));

                //Targil 2
                //var query2 = product.Where(x => x.Discontinued == false).ToList();
                //query2.ForEach(y => Console.WriteLine($"Prodcut ID : {y.ProductId} \nProduct Name : {y.ProductName}"));

                //Targil 3
                //var query3 = from x in product
                //             where x.Discontinued == true
                //             select new {ProductID = x.ProductId, ProductName = x.ProductName};
                //query3.ToList().ForEach(x => Console.WriteLine($"Prodcut ID : {x.ProductID} \nProduct Name : {x.ProductName}"));

                //Targil 4
                //var minPrice = product.Min(x => x.UnitPrice);
                //var maxPrice = product.Max(x => x.UnitPrice);
                //var query4 = product.Where(x => x.UnitPrice == minPrice || x.UnitPrice == maxPrice).ToList();
                //query4.ForEach(x => Console.WriteLine($"Product Name : {x.ProductName} \nPrice : {x.UnitPrice}"));

                //Targil 5
                //var query5 = from x in product
                //             where x.UnitPrice < 20 && x.Discontinued == false
                //             select new { ProductID = x.ProductId, ProductName = x.ProductName, ProductPrice = x.UnitPrice };
                //query5.ToList().ForEach(x => Console.WriteLine($"Product ID : {x.ProductID} \nProduct Name : {x.ProductName} \nProduct Price : {x.ProductPrice}"));

                //Targil 6
                //var query6 = product.Where(x => x.UnitPrice >= 15 && x.UnitPrice <= 25).ToList();
                //query6.ForEach(x => Console.WriteLine($"Product ID : {x.ProductId} \nProduct Name : {x.ProductName} \nProduct Price : {x.UnitPrice}"));

                //Targil 7
                //var average = product.Average(x => x.UnitPrice);
                //var query7 = db.Products.Where(x => x.UnitPrice > average);
                //query7.ToList().ForEach(x => Console.WriteLine($"{x.UnitPrice}"));

                //Targil 8
                //var query8 = from x in product
                //             orderby x.UnitPrice descending
                //             select new { ProductName = x.ProductName, ProductPrice = x.UnitPrice };
                //query8.Take(10).ToList().ForEach(x => Console.WriteLine($"Product Name : {x.ProductName} \nProduct Price : {x.ProductPrice}"));

                //Targil 9
                //var dis = product.Where(x => x.Discontinued == true).Count();
                //var cont = product.Where(x => x.Discontinued == false).Count();
                //Console.WriteLine($"Discontinued products : {dis} \nCurrent products : {cont}");

                //Targil 10
                //var query10 = product;
                //query10.Where(x => x.UnitsInStock < x.UnitsOnOrder).ToList().ForEach(x => Console.WriteLine($"Product Name : {x.ProductName} \nIn stock : {x.UnitsInStock} \nIn order : {x.UnitsOnOrder}"));
            }
        }
    }
}