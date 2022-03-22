using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAvaliacaoMedidas : ServiceConnection
    {
        public ServiceAvaliacaoMedidas(string path) : base(path)
        {
            //criando tabela AvaliacaoMedidas
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST AvaliacaoMedidas (                                                                 " +
                        "                                                                          IdAvaliacaoMedidas INT PRIMARY KEY IDENTITY(1,1),                " +
                        "                                                                          IdAvaliacao INT FOREIGN KEY REFERENCES Avaliacao(IdAvaliacao),   " +
                        "                                                                          Peso NUMERIC(9, 2),                                              " +
                        "                                                                          Altura INT,                                                      " +
                        "                                                                          DobraTriciptal NUMERIC(9, 2),                                    " +
                        "                                                                          DobraSubescapular NUMERIC(9, 2),                                 " +
                        "                                                                          DobraBiciptal NUMERIC(9, 2),                                     " +
                        "                                                                          DobraAxilarMedia NUMERIC(9, 2),                                  " +
                        "                                                                          DobraSupraIliaca NUMERIC(9, 2),                                  " +
                        "                                                                          DobraToracica NUMERIC(9, 2),                                     " +
                        "                                                                          DobraCoxaSuperior NUMERIC(9, 2),                                 " +
                        "                                                                          DobraCoxaMedial NUMERIC(9, 2),                                   " +
                        "                                                                          DobraCoxaInferior NUMERIC(9, 2),                                 " +
                        "                                                                          DobraAbdominal NUMERIC(9, 2),                                    " +
                        "                                                                          DobraPanturrilhaMedial NUMERIC(9, 2),                            " +
                        "                                                                          CircunferenciaAntebracoDireito NUMERIC(9, 2),                    " +
                        "                                                                          CircunferenciaAntebracoEsquerdo NUMERIC(9, 2),                   " +
                        "                                                                          CircunferenciaBracoDireitoRelaxado NUMERIC(9, 2),                " +
                        "                                                                          CircunferenciaBracoEsquerdoRelaxado NUMERIC(9, 2),               " +
                        "                                                                          CircunferenciaBracoDireitoContraido NUMERIC(9, 2),               " +
                        "                                                                          CircunferenciaBracoEsquerdoContraido NUMERIC(9, 2),              " +
                        "                                                                          CircunferenciaTorax NUMERIC(9, 2),                               " +
                        "                                                                          CircunferenciaCintura NUMERIC(9, 2),                             " +
                        "                                                                          CircunferenciaQuadril NUMERIC(9, 2),                             " +
                        "                                                                          CircunferenciaAbdominal NUMERIC(9, 2),                           " +
                        "                                                                          CircunferenciaCoxaSuperiorDireito NUMERIC(9, 2),                 " +
                        "                                                                          CircunferenciaCoxaMedialDireito NUMERIC(9, 2),                   " +
                        "                                                                          CircunferenciaCoxaInferiorDireito NUMERIC(9, 2),                 " +
                        "                                                                          CircunferenciaCoxaSuperiorEsquerdo NUMERIC(9, 2),                " +
                        "                                                                          CircunferenciaCoxaMedialEsquerdo NUMERIC(9, 2),                  " +
                        "                                                                          CircunferenciaCoxaInferiorEsquerdo NUMERIC(9, 2),                " +
                        "                                                                          CircunferenciaPanturrilhaDireito NUMERIC(9, 2),                  " +
                        "                                                                          CircunferenciaPanturrilhaEsquerdo NUMERIC(9, 2))                 ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
