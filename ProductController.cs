using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products_Task.IBussinessLogic;
using Products_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductlogic _productlogic;
        public ProductController(IProductlogic productlogic)
        {
            _productlogic = productlogic;
        }

        [Route("api/AddProducts")]
        [HttpPost]
        public int AddProducts(Producttbl producttbl)
        {
            return _productlogic.AddProducts(producttbl);
        }

        [Route("api/Deleteproducts")]
        [HttpDelete]
        public int Deleteproducts(int Id)
        {
            return _productlogic.Deleteproducts(Id);
        }

        [Route("api/GetProducts")]
        [HttpGet]
        public List<Producttbl> GetProducts()
        {
            return _productlogic.GetProducts();
        }

        [Route("api/GetProducttblById")]
        [HttpGet]
        public Producttbl GetProducttblById(int Id)
        {
            return _productlogic.GetProducttblById(Id);
        }


        [Route("api/UpdateProducts")]
        [HttpPut]
        public int UpdateProducts(Producttbl producttbl)
        {
            return _productlogic.UpdateProducts(producttbl);
        }
    }
}
