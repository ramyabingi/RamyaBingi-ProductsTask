using Products_Task.IRepository;
using Products_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Task.Repository
{
    public class ProductRepo : IProductRepo
    {
        ProductsDBContext productsDB = new ProductsDBContext();
        public int AddProducts(Producttbl producttbl)
        {
            productsDB.Producttbls.Add(producttbl);
            productsDB.SaveChanges();
            return 1;
        }

        public int Deleteproducts(int Id)
        {
            var data = productsDB.Producttbls.Where(a => a.Sn == Id).FirstOrDefault();
            productsDB.Producttbls.Remove(data);
            productsDB.SaveChanges();
            return 1;
        }

        public List<Producttbl> GetProducts()
        {
            return productsDB.Producttbls.ToList();
        }

        public Producttbl GetProducttblById(int Id)
        {
            var d = productsDB.Producttbls.Where(r => r.Sn == Id).FirstOrDefault();
            return d;
        }

        public int UpdateProducts(Producttbl producttbl)
        {
            productsDB.Producttbls.Update(producttbl);
            productsDB.SaveChanges();
            return 1;
        }
    }
}
