using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAvaliacao
    {
        public int IdAvaliacao { get; set; }

        public int IdAgendamento { get; set; }

        public int IdAvaliacaoProtocolo { get; set; }

        public bool Avaliado { get; set; }

        public ModelAvaliacao()
        {
            IdAvaliacao = 0;
            IdAgendamento = 0;
            IdAvaliacaoProtocolo = 0;
            Avaliado = false;
        }
    }
}
