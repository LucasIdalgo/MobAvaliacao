using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceProfissional : ServiceConnection
    {
        public ServiceProfissional(string path) : base(path)
        {
            //criando tabela Profissional
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Profissional (                                                             " +
                "                                                                              IdProfissional INT PRIMARY KEY IDENTITY(1,1),                " +
                "                                                                              IdEntidade INT FOREIGN KEY REFERENCES Entidade(IdEntidade),  " +
                "                                                                              CREF VARCHAR(11) NOT NULL)                                   ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
