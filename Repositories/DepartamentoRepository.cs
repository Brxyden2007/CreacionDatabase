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
    public class DepartamentoRepository : IGenericRepository<Departamento>, IDepartamentoRepository
    {

        private readonly ConexionSingleton _conexion;
        public DepartamentoRepository(string connectionString)
        {
            _conexion = ConexionSingleton.Instancia(connectionString);
        }
        public void Actualizar(Departamento entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Departamento departamento)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO departamentos (name) VALUES (@name)";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", departamento.Name);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}