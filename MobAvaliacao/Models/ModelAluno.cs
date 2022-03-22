using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAluno
    {
        public int IdAluno { get; set; }

        public int IdEntidade { get; set; }

        public int IdProfissional { get; set; }

        public string Objetivo { get; set; }

        public string Lesao { get; set; }

        public string Comorbidade { get; set; }

        public ModelAluno()
        {
            IdAluno = 0;
            IdEntidade = 0;
            IdProfissional = 0;
            Objetivo = null;
            Lesao = null;
            Comorbidade = null;
        }
    }
}
