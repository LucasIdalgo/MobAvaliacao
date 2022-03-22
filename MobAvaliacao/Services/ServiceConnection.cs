using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace MobAvaliacao.Services
{
    public class ServiceConnection
    {
        public SqliteConnection connection;

        public string StatusMessage { get; set; }

        public ServiceConnection(string path)
        {
            if (string.IsNullOrEmpty(path))
                path = App.dbPath;

            connection = new SqliteConnection(path);
        }
    }
}
