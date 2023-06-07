using Products_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Task.IRepository
{
   public interface IProductRepo
    {
        public List<Producttbl> GetProducts();
        public int AddProducts(Producttbl producttbl);
        public int UpdateProducts(Producttbl producttbl);
        public int Deleteproducts(int Id);
        public Producttbl GetProducttblById(int Id);
    }
}
