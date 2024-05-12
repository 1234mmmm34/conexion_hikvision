using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using CardManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace conexion_hikvision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConexionController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [EnableCors]
        [Route("login")]


        public int login()
        {
            return AddDevice.Login("x", "x", "x", "x");


        }
    }
}
