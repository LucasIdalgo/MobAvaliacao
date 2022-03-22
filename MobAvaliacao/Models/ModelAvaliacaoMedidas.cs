using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelAvaliacaoMedidas
    {
        public int IdAvaliacaoMedidas { get; set; }

        public int IdAvaliacao { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public double DobraTriciptal { get; set; }

        public double DobraSubescapular { get; set; }

        public double DobraBiciptal { get; set; }

        public double DobraAxilarMedia { get; set; }

        public double DobraSupraIliaca { get; set; }

        public double DobraToracica { get; set; }

        public double DobraCoxaSuperior { get; set; }

        public double DobraCoxaMedial { get; set; }

        public double DobraCoxaInferior { get; set; }

        public double DobraAbdominal { get; set; }

        public double DobraPanturrilhaMedial { get; set; }

        public double CircunferenciaAntebracoDireito { get; set; }

        public double CircunferenciaAntebracoEsquerdo { get; set; }

        public double CircunferenciaBracoDireitoRelaxado { get; set; }

        public double CircunferenciaBracoEsquerdoRelaxado { get; set; }

        public double CircunferenciaBracoDireitoContraido { get; set; }

        public double CircunferenciaBracoEsquerdoContraido { get; set; }

        public double CircunferenciaTorax { get; set; }

        public double CircunferenciaCintura { get; set; }

        public double CircunferenciaQuadril { get; set; }

        public double CircunferenciaAbdominal { get; set; }

        public double CircunferenciaCoxaSuperiorDireito { get; set; }

        public double CircunferenciaCoxaMedialDireito { get; set; }

        public double CircunferenciaCoxaInferiorDireito { get; set; }

        public double CircunferenciaCoxaSuperiorEsquerdo { get; set; }

        public double CircunferenciaCoxaMedialEsquerdo { get; set; }

        public double CircunferenciaCoxaInferiorEsquerdo { get; set; }

        public double CircunferenciaPanturrilhaDireito { get; set; }

        public double CircunferenciaPanturrilhaEsquerdo { get; set; }

        public ModelAvaliacaoMedidas()
        {
            IdAvaliacaoMedidas = 0;
            IdAvaliacao = 0;
            Peso = 0;
            Altura = 0;
            DobraAbdominal = 0;
            DobraAxilarMedia = 0;
            DobraBiciptal = 0;
            DobraCoxaInferior = 0;
            DobraCoxaMedial = 0;
            DobraCoxaSuperior = 0;
            DobraPanturrilhaMedial = 0;
            DobraSubescapular = 0;
            DobraSupraIliaca = 0;
            DobraToracica = 0;
            DobraTriciptal = 0;
            CircunferenciaAbdominal = 0;
            CircunferenciaAntebracoDireito = 0;
            CircunferenciaAntebracoEsquerdo = 0;
            CircunferenciaBracoDireitoContraido = 0;
            CircunferenciaBracoDireitoRelaxado = 0;
            CircunferenciaBracoEsquerdoContraido = 0;
            CircunferenciaBracoEsquerdoRelaxado = 0;
            CircunferenciaCintura = 0;
            CircunferenciaCoxaInferiorDireito = 0;
            CircunferenciaCoxaInferiorEsquerdo = 0;
            CircunferenciaCoxaMedialDireito = 0;
            CircunferenciaCoxaMedialEsquerdo = 0;
            CircunferenciaCoxaSuperiorDireito = 0;
            CircunferenciaCoxaSuperiorEsquerdo = 0;
            CircunferenciaPanturrilhaDireito = 0;
            CircunferenciaPanturrilhaEsquerdo = 0;
            CircunferenciaQuadril = 0;
            CircunferenciaTorax = 0;
        }
    }
}
