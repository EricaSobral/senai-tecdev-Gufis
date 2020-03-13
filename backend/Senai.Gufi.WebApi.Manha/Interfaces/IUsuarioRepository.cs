using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Lista();

        void CadastrarUsuario(Usuario novoUsuario);

        void AtualizarUsuario(int id, Usuario UsuarioAtualizado);

        void DeletarUsuario(int id);

        Usuario BuscarUsuarioPorId(int id);
    }
}
