using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAvaliacaoResultados
    {
        public int IdAvaliacaoResultados { get; set; }

        public int IdAvaliacao { get; set; }

        public double PesoMassaMagra { get; set; }

        public double PesoGordura { get; set; }

        public double PorcentagemGordura { get; set; }

        public double IMC { get; set; }

        public ModelAvaliacaoResultados()
        {
            IdAvaliacaoResultados = 0;
            IdAvaliacao = 0;
            PesoMassaMagra = 0;
            PesoGordura = 0;
            IMC = 0;
        }
    }
}
