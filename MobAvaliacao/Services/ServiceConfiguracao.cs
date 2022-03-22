using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Services
{
    public class ServiceConfiguracao : ServiceConnection
    {
        public ServiceConfiguracao(string path) : base(path)
        {
            //criando tabela Configuracao
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Configuracao (                                                                         " +
                    "                                                                          IdConfiguracao INT PRIMARY KEY IDENTITY(1,1),                            " +
                    "                                                                          IdEntidade INT FOREIGN KEY REFERENCES Entidade(IdEntidade),              " +
                    "                                                                          IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),                 " +
                    "                                                                          IdProfissional INT FOREIGN KEY REFERENCES Profissional(IdProfissional),  " +
                    "                                                                          ManterLogado BIT NOT NULL,                                               " +
                    "                                                                          ModoDark BIT NOT NULL)                                                   ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
