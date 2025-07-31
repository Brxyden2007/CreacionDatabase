using agendadb.Data;
using agendadb.Factory;
using agendadb.Mysql;
using agendadb.Services;
using MySql.Data.MySqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        string connStr = "server=localhost;database=introcsharp;user=campus2023;password=campus2023;";

        var dbInit = new DatabaseInitializer(connStr);
        dbInit.DropTablas();
        dbInit.CrearTablas();

        IDbFactory factory = new MySqlDbFactory(connStr);
        var servicio = new ClienteService(factory.CrearClienteRepository());
        var servicioPais = new PaisService(factory.CrearPaisRepository());
        var servicioDepartamento = new DepartamentoService(factory.CrearDepartamentoRepository());
        servicio.CrearCliente("Pepe");
        servicio.CrearCliente("Daniela");
        servicioPais.CrearPais("España");
        servicioPais.CrearPais("Colombia");
        servicioDepartamento.CrearDepartamento("Santander");
        servicioDepartamento.CrearDepartamento("Barranquilla");

    }
}