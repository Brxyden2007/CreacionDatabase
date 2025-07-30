using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendadb.Models;
using agendadb.Ports;

namespace agendadb.Services
{
    public class PaisService
    {
         private readonly IPaisRepository _repo;

        public PaisService(IPaisRepository repo)
        {
            _repo = repo;
        }

        public void CrearPais(string nombre)
        {
            _repo.Crear(new Pais { Name = nombre });
        }

        public void ActualizarPais(int id, string nuevoNombre)
        {
            _repo.Actualizar(new Pais { Id = id, Name = nuevoNombre });
        }

        public void EliminarPais(int id)
        {
            _repo.Eliminar(id);
        }       
    }
}