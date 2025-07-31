using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Models;

namespace agendadb.Ports
{
    public interface IDepartamentoRepository
    {
        void Actualizar(Departamento departamento);
        void Crear(Departamento departamento);
        void Eliminar(int id);
    }
}