using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Models;

namespace agendadb.Ports
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        List<Cliente> ObtenerTodosClientes();
    }
}