using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private static List<Cliente> clientes = new List<Cliente>
    {
        new Cliente { ID = 1, Nombres = "Juan", Apellidos = "Pérez", Genero = "Masculino", FechaNacimiento = "1990-01-01", Estado = true }
    };

    [HttpGet]
    public IActionResult GetClientes()
    {
        return Ok(clientes);
    }

    [HttpPost]
    public IActionResult CrearCliente([FromBody] Cliente cliente)
    {
        clientes.Add(cliente);
        return Ok(cliente);
    }
}

public class Cliente
{
    public int ID { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Genero { get; set; }
    public string FechaNacimiento { get; set; }
    public bool Estado { get; set; }
}
