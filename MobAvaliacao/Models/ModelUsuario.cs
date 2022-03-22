using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelUsuario
    {
        public int IdUsuario { get; set; }

        public int IdEntidade { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public ModelUsuario()
        {
            IdUsuario = 0;
            IdEntidade = 0;
            Login = "";
            Senha = "";
        }
    }
}
