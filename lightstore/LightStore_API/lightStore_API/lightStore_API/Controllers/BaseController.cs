using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lightStore_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace lightStore_API.Controllers
{
  public class BaseController : Controller
  {
    protected LightStoreDbContext DbContext;

    public BaseController(LightStoreDbContext context,
        IConfiguration configuration)
    {
      DbContext = context;
    }
  }
}
