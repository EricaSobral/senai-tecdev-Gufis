﻿using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IPresencaRepository
    {
        List<Presenca> Listar();

        void CadastraPresenca (Presenca novaPresenca);

        void AtualizarPresenca (int id, Presenca presencaAtualizado);

        void DeletarPresenca (int id);

        Presenca BuscarPresencaPorId(int id);
    }
}
