using Products_Task.IBussinessLogic;
using Products_Task.IRepository;
using Products_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Task.Bussinesslogic
{
    public class ProductLogic : IProductlogic
    {
        IProductRepo _productRepo;
        public ProductLogic(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public int AddProducts(Producttbl producttbl)
        {
            return _productRepo.AddProducts(producttbl);
        }

        public int Deleteproducts(int Id)
        {
            return _productRepo.Deleteproducts(Id);
        }

        public List<Producttbl> GetProducts()
        {
            return _productRepo.GetProducts();
        }

        public Producttbl GetProducttblById(int Id)
        {
            return _productRepo.GetProducttblById(Id);
        }

        public int UpdateProducts(Producttbl producttbl)
        {
            return _productRepo.UpdateProducts(producttbl);
        }
    }
}
