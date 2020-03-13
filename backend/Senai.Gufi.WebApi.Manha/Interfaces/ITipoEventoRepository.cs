using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface ITipoEventoRepository
    {
        List<TipoEvento> Listar();

        void CadastrarTipoEvento(TipoEvento novoTipoEvento);

        void AtualizarTipoEvento(int id, TipoEvento tipoEventoAtualizado);

        void DeletarTipoEvento(int id);

        TipoEvento BuscarTipoEventoPorId(int id);
    }
}
