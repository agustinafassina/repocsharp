using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repocsharp.Models;

namespace repocsharp.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public IEnumerable<Product> GetAll(){
            return new List<Product>{
                new Product {
                    ProductId=1,
                    Name = "Aguuus",
                    Description="probandoooo"
                },
                new Product {
                    ProductId=2,
                    Name = "Luciooo",
                    Description="seeee probandoooo"
                },
            };
        }
    }
}