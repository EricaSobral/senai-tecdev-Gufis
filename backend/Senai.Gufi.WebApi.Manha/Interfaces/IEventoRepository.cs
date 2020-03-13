using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> Listar();

        void CadastrarEvento(Evento novoEvento);

        void AtualizarEvento(int id, Evento EventoAtualizado);

        void DeletarEvento(int id);

        Evento BuscarEventoPorId(int id);

    }
}
