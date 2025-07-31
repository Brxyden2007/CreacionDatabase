using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Models;
using agendadb.Mysql;
using agendadb.Ports;

namespace agendadb.Services
{
    public class DepartamentoService
    {
        private readonly IDepartamentoRepository _repo;
        public DepartamentoService(IDepartamentoRepository repo)
        {
            _repo = repo;
        }

        public void CrearDepartamento(string nombre)
        {
            _repo.Crear(new Departamento { Name = nombre });
        }

        public void ActualizarDepartamento(int id, string nuevoNombre)
        {
            _repo.Actualizar(new Departamento { Id = id, Name = nuevoNombre });
        }

        public void EliminarDepartamento(int id)
        {
            _repo.Eliminar(id);
        }
    }
}
