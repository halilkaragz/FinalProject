using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //----> ATTRIBUTE : Bir class ile ilgili bilgi verme ve onu imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        //Naming convention
        //Ioc Container : Inversion of Control Container
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]   
        public List<Product> Get()
        {
            //Dependency chain --
            
            var Result = _productService.GetAll();
            return Result.Data;
        }
    }
}
