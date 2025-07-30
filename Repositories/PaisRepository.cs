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
    public class PaisRepository : IGenericRepository<Pais>, IPaisRepository
    {
         private readonly ConexionSingleton _conexion;
        public PaisRepository(string connectionString)
        {
            _conexion = ConexionSingleton.Instancia(connectionString);
        }
        public void Actualizar(Pais entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Pais pais)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO paises (name) VALUES (@name)";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", pais.Name);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}