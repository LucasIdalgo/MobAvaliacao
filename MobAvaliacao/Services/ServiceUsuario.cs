using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace MobAvaliacao.Services
{
    public class ServiceUsuario : ServiceConnection
    {
        public ServiceUsuario(string path) : base(path)
        {
            //criando tabela Usuario
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Usuario (                                                           " +
                "                                                                         IdUsuario INT PRIMARY KEY IDENTITY(1,1),                   " +
                "                                                                         IdEntidade INT FOREIGN KEY REFERENCES Entidade(IdEntidade)," +
                "                                                                         Login VARCHAR(50) NOT NULL,                                " +
                "                                                                         Senha VARCHAR(50) NOT NULL))                               ", connection);
            var result = command.ExecuteNonQuery();

            if (result!=0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
