using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void AtualizarTipoEvento(int id, TipoEvento tipoEventoAtualizado)
        {
            TipoEvento tipoEventoBuscado = ctx.TipoEvento.Find(id);

            tipoEventoBuscado.TituloTipoEvento = tipoEventoAtualizado.TituloTipoEvento;

            ctx.TipoEvento.Update(tipoEventoBuscado);

            ctx.SaveChanges();
        }

        public TipoEvento BuscarTipoEventoPorId(int id)
        {
            return ctx.TipoEvento.FirstOrDefault(te => te.IdTipoEvento == id);
        }

        public void CadastrarTipoEvento(TipoEvento novoTipoEvento)
        {
            ctx.TipoEvento.Add(novoTipoEvento);

            ctx.SaveChanges();
        }

        public void DeletarTipoEvento(int id)
        {
            ctx.TipoEvento.Remove(BuscarTipoEventoPorId(id));

            ctx.SaveChanges();
        }

        public List<TipoEvento> Listar()
        {
            return ctx.TipoEvento.ToList();
        }
    }
}
