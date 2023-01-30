using FullStackAPI.data;
using FullStackAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace FullStackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class empleadosController : Controller
    {
        private readonly FullStackDbContex _fullStackDbContex;

        public empleadosController(FullStackDbContex fullStackDbContex)
        {
            _fullStackDbContex = fullStackDbContex;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllempleados()
        {
            var empleados = await _fullStackDbContex.empleados.ToListAsync();
            return Ok(empleados);   
        }

        [HttpPost]
        public async Task<IActionResult> Addempleados([FromBody]empleado empleadoRequest)
        {
            await _fullStackDbContex.empleados.AddAsync(empleadoRequest);
            await _fullStackDbContex.SaveChangesAsync();

            return Ok(empleadoRequest);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetEmpleado([FromRoute] Guid id)
        {
            var empleado = await _fullStackDbContex.empleados.FirstOrDefaultAsync(x => x.id == id);

            if (empleado == null)
            {
                return NotFound();
            }

            return Ok(empleado);
        }


    }
}
