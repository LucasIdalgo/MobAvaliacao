using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelProfissional
    {
        public int IdProfiossional { get; set; }

        public int IdEntidade { get; set; }

        public string CREF { get; set; }

        public ModelProfissional()
        {
            IdProfiossional = 0;
            IdEntidade = 0;
            CREF = "";
        }
    }
}
