using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using CardManagement;

namespace conexion_hikvision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConexionController : ControllerBase
    {
        [HttpGet]
        [Route("login")]


        public bool login()
        {
            return AddDevice.Login("admin", "Repara123", "5551", "187.216.118.73");


        }
    }
}
