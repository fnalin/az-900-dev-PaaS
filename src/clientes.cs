using System.Linq;
using cadcli;
using Microsoft.AspNetCore.Mvc;

namespace cadcliapi
{
    public class Clientes: Controller
    {
        [HttpGet("api/clientes")]
        public IActionResult Get()
        {

            var db = new dal();
            var data = db.Clientes.ToList();

            return Ok(data);
        }
    }
}