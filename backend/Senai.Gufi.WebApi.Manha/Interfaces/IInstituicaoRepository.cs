﻿using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();

        void CadastraInstituicao(Instituicao novaInstituicao);

        void AtualizarInstituicao(int id, Instituicao instituicaoAtualizado);

        void DeletarInstituicao(int id);

        Presenca BuscarInstituicaoPorId(int id);
    }
}
