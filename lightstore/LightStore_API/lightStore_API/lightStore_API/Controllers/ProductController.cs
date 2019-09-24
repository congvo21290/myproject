using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lightStore_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace lightStore_API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : BaseController
  {
    public ProductController(LightStoreDbContext context, IConfiguration configuration) :
          base(context, configuration){ }

    /// <summary>
    /// Get all product
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAll()
    {
      var products = DbContext.Products.ToList();
      return Ok(products);
    }


    /// <summary>
    /// Get produt by categoryId
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("categoryid/{categoryId}")]
    public async Task<IActionResult> GetProductByCategoryId(int categoryId)
    {
      var products = DbContext.Products.Where(c => c.CategoryId == categoryId).ToList();

      return Ok(products);
    }

    /// <summary>
    /// Get produt by id
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
      var product = DbContext.Products.FirstOrDefault(c => c.Id == id);

      return Ok(product);
    }
  }
}
