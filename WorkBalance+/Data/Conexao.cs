using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBalance_.Data
{
    public class Conexao
    {
        public static string GetDatabasePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dataFolder = Path.Combine(basePath, "Data");
            Directory.CreateDirectory(dataFolder);

            string dbPath = Path.Combine(dataFolder, "WorkBalance.db");

            string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "WorkBalance.db");

            if (!File.Exists(dbPath) && File.Exists(origem))
                File.Copy(origem, dbPath);

            return dbPath;
        }
    }
}
