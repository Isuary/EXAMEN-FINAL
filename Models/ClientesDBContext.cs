using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Models
{
    public class ClientesDBContext : DbContext
    {
        public ClientesDBContext(DbContextOptions<ClientesDBContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionGeneral> InformacionGenerals { get; set; }
    }

    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }
    }

    public class InformacionGeneral
    {
        public int ID { get; set; }
        public string TipoInformacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreador { get; set; }
        public bool Estado { get; set; }
        public int ClienteID { get; set; }
    }
}

