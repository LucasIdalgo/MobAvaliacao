using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAvaliacaoProtocolo : ServiceConnection
    {
        public ServiceAvaliacaoProtocolo(string path) : base(path)
        {
            //criando tabela AvaliacaoProtocolo
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST AvaliacaoProtocolo (                                                   " +
                            "                                                                        IdAvaliacaoProtocolo INT PRIMARY KEY IDENTITY(1,1)," +
                            "                                                                        NomeProtocolo VARCHAR(50) NOT NULL,                " +
                            "                                                                        Observacao VARCHAR(100))                           ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
