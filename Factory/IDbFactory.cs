using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Ports;

namespace agendadb.Factory
{
    public interface IDbFactory
    {
        IClienteRepository CrearClienteRepository();
        IPaisRepository CrearPaisRepository();
    }
}