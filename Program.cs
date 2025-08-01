using agendadb.Data;
using agendadb.Factory;
using agendadb.Mysql;
using agendadb.Services;
using MySql.Data.MySqlClient;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        string connStr = "server=localhost;user=root;password=BRAYDEN714bRayden714;";

        var dbInit = new DatabaseInitializer(connStr);
        dbInit.CreateDatabase();
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

// Modificacion 9:26 p.m. = Quite el database en el connStr, ya que me interfiere a la hora de crear la base de datos