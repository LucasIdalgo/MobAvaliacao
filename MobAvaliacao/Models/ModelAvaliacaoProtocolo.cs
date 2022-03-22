using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAvaliacaoProtocolo
    {
        public int IdAvaliacaoProtocolo { get; set; }

        public string NomeProtocolo { get; set; }

        public string Observacao { get; set; }

        public ModelAvaliacaoProtocolo()
        {
            IdAvaliacaoProtocolo = 0;
            NomeProtocolo = "";
            Observacao = null;
        }
    }
}
