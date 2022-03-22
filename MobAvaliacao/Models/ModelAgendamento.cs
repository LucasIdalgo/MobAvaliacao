using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAgendamento
    {
        public int IdAgendamento { get; set; }

        public int IdAluno { get; set; }

        public int IdProfissional { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public ModelAgendamento()
        {
            IdAgendamento = 0;
            IdAluno = 0;
            IdProfissional = 0;
            DataFinal = DateTime.MinValue;
            DataInicial = DateTime.MinValue;
        }
    }
}
