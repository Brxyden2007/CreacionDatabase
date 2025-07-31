using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Factory;
using agendadb.Ports;
using agendadb.Repositories;

namespace agendadb.Mysql
{
    public class MySqlDbFactory : IDbFactory
    {
        private readonly string _connectionString;
        public MySqlDbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IClienteRepository CrearClienteRepository()
        {
            return new ClienteRepository(_connectionString);
        }

        public IPaisRepository CrearPaisRepository()
        {
            return new PaisRepository(_connectionString);
        }

        public IDepartamentoRepository CrearDepartamentoRepository()
        {
            return new DepartamentoRepository(_connectionString);
        }
    }
}

