using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAvaliacao : ServiceConnection
    {
        public ServiceAvaliacao(string path) : base(path)
        {
            //criando tabela Avaliacao
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Avaliacao (                                                                                            " +
                "                                                                           IdAvaliacao INT PRIMARY KEY IDENTITY(1,1),                                                  " +
                "                                                                           IdAgendamento INT FOREIGN KEY REFERENCES Agendamento(IdAgendamento),                        " +
                "                                                                           IdAvaliacaoProtocolo INT FOREIGN KEY REFERENCES AvaliacaoProtocolo(IdAvaliacaoProtocolo))   ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
