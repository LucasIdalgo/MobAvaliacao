using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelConfiguracao
    {
        public int IdConfiguracao { get; set; }

        public int IdEntidade { get; set; }

        public int IdUsuario { get; set; }

        public int IdProfissional { get; set; }

        public bool ManterLogado { get; set; }

        public bool ModoDark { get; set; }

        public ModelConfiguracao()
        {
            IdEntidade = 0;
            IdProfissional = 0;
            IdUsuario = 0;
            ManterLogado = false;
            ModoDark = false;
        }
    }
}
