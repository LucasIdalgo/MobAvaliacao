using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceAluno : ServiceConnection
    {
        public ServiceAluno(string path) : base(path)
        {
            //criando tabela Aluno
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Aluno (                                                                        " +
                "                                                                       IdAluno INT PRIMARY KEY IDENTITY(1,1),                                  " +
                "                                                                       IdEntidade INT FOREIGN KEY REFERENCES Entidade(IdEntidade),             " +
                "                                                                       IdProfissional INT FOREIGN KEY REFERENCES Profissional(IdProfissional), " +
                "                                                                       Objetivo VARCHAR(MAX),                                                  " +
                "                                                                       Lesao VARCHAR(MAX),                                                     " +
                "                                                                       Comorbidade VARCHAR(MAX))                                               ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
