﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackProcesso.Models;

namespace TechStackBack.IRepositories
{
    public interface INivelConhecimentoRepository
    {
        Task<NivelConhecimento> ObterPorId(int idNivelConhecimento);
    }
}
