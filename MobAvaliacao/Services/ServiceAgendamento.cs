using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAgendamento : ServiceConnection
    {
        public ServiceAgendamento(string path) : base(path)
        {
            //criando tabela Agendamento
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Agendamento (                                                                          " +
                "                                                                             IdAgendamento INT PRIMARY KEY IDENTITY(1,1),                              " +
                "                                                                             IdAluno INT FOREIGN KEY REFERENCES Aluno(IdAluno),                        " +
                "                                                                             IdProfissional INT FOREIGN KEY REFERENCES Profissional(IdProfissional),   " +
                "                                                                             DataInicial DATETIME NOT NULL,                                            " +
                "                                                                             DataFinal DATETIME NOT NULL)                                              ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
