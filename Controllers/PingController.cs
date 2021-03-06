using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GPCalAPI.Models;
using Microsoft.AspNetCore.Authorization;


namespace GPCalAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class PingController : ControllerBase
  {
    [HttpGet]
    public object Get()
    {
      var userId = User.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
      return userId;
    }
  }
}