using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace CarReportSystem {
    public static class Database {
        private static readonly string DatabasePath =
            Path.Combine(AppContext.BaseDirectory, "carreport.db");

        private static readonly string ConnectionString =
            $"Data Source={DatabasePath}";

        public static SqliteConnection GetConnection()
            => new SqliteConnection(ConnectionString);

        public static void Initialize() {
            //接続オブジェクトを生成する
            using var connection = GetConnection();

            //DBを開く
            connection.Open();

            //sqlを実行するためのコマンドプロジェクトを作る

            using var command = connection.CreateCommand();

            //接続してCREATE TABLE IF NOT EXISTSを実行
            command.CommandText =
                """
                CREATE TABLE IF NOT EXISTS CarReports(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Data TEXT NOT NULL,
                 Author TEXT NOT NULL,
                 Maker INTEGER NOT NULL,
                 CarName TEXT NOT NULL,
                 Report TEXT NOT NULL,
                 Picture BLOB
                 );

                """;
            command.ExecuteNonQuery();
        }
    }
}
