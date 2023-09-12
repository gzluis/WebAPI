using EjemploWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    List<Producto> productos = new List<Producto>(){
        new Producto{ Id = 1, Nombre = "USB", Precio = 3},
        new Producto{ Id = 2, Nombre = "Laptop", Precio = 500},
        new Producto{ Id = 1, Nombre = "Teclado", Precio = 20},
    };

    [HttpGet]
    public IEnumerable<Producto> Get(){
        return productos;
    }

    [HttpGet("{id}")]
    public Producto? GetById(int id){
        return productos.Where(x=>x.Id == id).FirstOrDefault();
    }


}

