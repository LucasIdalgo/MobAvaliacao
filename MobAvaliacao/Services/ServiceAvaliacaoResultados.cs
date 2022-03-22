using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAvaliacaoResultados : ServiceConnection
    {
        public ServiceAvaliacaoResultados(string path) : base(path)
        {
            //criando tabela AvaliacaoResultado
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST AvaliacaoResultado (                                                               " +
                            "                                                                        IdAvaliacaoResultados INT PRIMARY KEY IDENTITY(1,1),           " +
                            "                                                                        IdAvaliacao INT FOREIGN KEY REFERENCES Avaliacao(IdAvaliacao), " +
                            "                                                                        PesoMassaMagra NUMERIC(9,2),                                   " +
                            "                                                                        PesoGordura NUMERIC(9,2),                                      " +
                            "                                                                        PorcentagemGordura NUMERIC(9,2),                               " +
                            "                                                                        IMC NUMERIC(9,2))                                              ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
