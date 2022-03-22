using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace MobAvaliacao.Services
{
    public class ServiceEntidade : ServiceConnection
    {
        public ServiceEntidade(string path) : base(path)
        {
            //criando tabela Entidade
            SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXIST Entidade (                                             " +
                "                                                                          IdEntidade INT PRIMARY KEY IDENTIITY(1,1),   " +
                "                                                                          DocumentoFederal VARCHAR(14) NOT NULL,       " +
                "                                                                          Nome VARCHAR(100) NOT NULL,                  " +
                "                                                                          DataNasc DATETIME NOT NULL,                  " +
                "                                                                          Sexo VARCHAR(1) NOT NULL,                    " +
                "                                                                          Ativo BIT NOT NULL,                          " +
                "                                                                          CEP VARCHAR(10) NOT NULL,                    " +
                "                                                                          Logradouro VARCHAR(200) NOT NULL,            " +
                "                                                                          Bairro VARCHAR(50) NOT NULL,                 " +
                "                                                                          Numero INT NOT NULL,                         " +
                "                                                                          Complemento VARCHAR(100),                    " +
                "                                                                          Referencia VARCHAR(200),                     " +
                "                                                                          Cidade VARCHAR(75) NOT NULL,                 " +
                "                                                                          UF VARCHAR(2) NOT NULL,                      " +
                "                                                                          Telefone1 VARCHAR(15) NOT NULL,              " +
                "                                                                          Telefone2 VARCHAR(15))                       ", connection);
            var result = command.ExecuteNonQuery();

            if (result != 0)
                StatusMessage = string.Format("Tabela criada com sucesso");
        }
    }
}
