using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace agendadb.Data
{
    public class DatabaseInitializer
    {
        private readonly string _connStr;

        public DatabaseInitializer(string connStr)
        {
            _connStr = connStr;
        }

        public void CreateDatabase()
        {
            using (var conexion = new MySqlConnection(_connStr))
            {
                conexion.Open();

                string databaseCreate = @"
                    DROP DATABASE IF EXISTS introcsharp;
                    CREATE DATABASE IF NOT EXISTS introcsharp";
                Ejecutar(databaseCreate, conexion);
            }
        }

        public void DropTablas()
        {
            using (var conexion = new MySqlConnection(_connStr))
            {
                conexion.Open();

                string dropTablaClientes = @"
                    DROP TABLE IF EXISTS clientes";

                string dropTablaPais = @"
                    DROP TABLE IF EXISTS paises;";

                string dropTablaDepartamento = @"
                    DROP TABLE IF EXISTS departamentos";

                // Ejecuta las consultas
                Ejecutar(dropTablaPais, conexion);
                Ejecutar(dropTablaDepartamento, conexion);
                Ejecutar(dropTablaClientes, conexion);
            }
        }

        public void CrearTablas()
        {
            using (var conexion = new MySqlConnection(_connStr))
            {
                conexion.Open();

                string crearTablaClientes = @"
                    CREATE TABLE IF NOT EXISTS clientes (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Nombre VARCHAR(100) NOT NULL
                    );";

                string crearTablaPais = @"
                    CREATE TABLE IF NOT EXISTS paises (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Name VARCHAR(100) NOT NULL
                    );";

                string crearTablaDepartamento = @"
                    CREATE TABLE IF NOT EXISTS departamentos (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Name VARCHAR(100) NOT NULL
                    );";

                // Ejecuta las consultas
                Ejecutar(crearTablaPais, conexion);
                Ejecutar(crearTablaDepartamento, conexion);
                Ejecutar(crearTablaClientes, conexion);
            }
        }

        private void Ejecutar(string query, MySqlConnection conexion)
        {
            using (var comando = new MySqlCommand(query, conexion))
            {
                comando.ExecuteNonQuery();
            }
        }
    }
}