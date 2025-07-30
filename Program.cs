using agendadb.Factory;
using agendadb.Mysql;
using agendadb.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        string connStr = "server=localhost;database=introcsharp;user=root;password=123456;";
        IDbFactory factory = new MySqlDbFactory(connStr);
        //var servicio = new ClienteService(factory.CrearClienteRepository());
        var servicioPais = new PaisService(factory.CrearPaisRepository());
        //servicio.CrearCliente("Pepe");
        servicioPais.CrearPais("España");

    }
}