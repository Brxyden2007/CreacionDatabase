using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Models;
using agendadb.Mysql;
using agendadb.Ports;
using MySql.Data.MySqlClient;

namespace agendadb.Repositories
{
    public class ClienteRepository : IGenericRepository<Cliente>, IClienteRepository
    {
        private readonly ConexionSingleton _conexion;
        public ClienteRepository(string connectionString)
        {
            _conexion = ConexionSingleton.Instancia(connectionString);
        }
        public void Actualizar(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Cliente cliente)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO clientes (nombre) VALUES (@nombre)";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtenerTodosClientes()
        {
            throw new NotImplementedException();
        }
    }
}