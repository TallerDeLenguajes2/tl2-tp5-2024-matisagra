using Microsoft.AspNetCore.Mvc;

namespace MiWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductosController : ControllerBase
{

    private ProductosRepository repoProductos = new ProductosRepository();


    [HttpPost("api/Producto")]
    public IActionResult CrearProductos(Producto producto)
    {
        repoProductos.CrearProducto(producto);
        return Created();

    }

    [HttpGet("api/Productos")]
    public ActionResult<List<Producto>> GetProductos()
    {
        return Ok(repoProductos.ObtenerProductos());
    }


    [HttpPut("api/Producto/{id}")]
    public IActionResult ModificarProductos(int id, Producto producto)
    {
        repoProductos.ModificarProducto(id, producto);
        return Ok();

    }

}