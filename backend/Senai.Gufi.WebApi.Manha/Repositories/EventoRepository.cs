using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void AtualizarEvento(int id, Evento EventoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Evento BuscarEventoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarEvento(Evento novoEvento)
        {
            throw new NotImplementedException();
        }

        public void DeletarEvento(int id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
