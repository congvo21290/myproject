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
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : BaseController
  {
    public CategoryController(LightStoreDbContext context, IConfiguration configuration) :
          base(context, configuration){ }

    /// <summary>
    /// Get all questions
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAll()
    {
      var questions = DbContext.Categorys.ToList();
      return Ok(questions);
    }


    /// <summary>
    /// Get category by id
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
      var question = DbContext.Categorys.FirstOrDefault(c => c.Id == id);

      return Ok(question);
    }
  }
}
