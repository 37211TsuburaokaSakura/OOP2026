using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReportRepoSitory {
        public List<CarReport> GetAll() {

            var products = new List<CarReport>();

            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();
            connection.Open();

            //sqlを実行するためのコマンドプロジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText = 
                """
                SELECT Id,Date,Author,Maker,CarName,Report,Picture
                FROM CarReports
                ORDER BY Id;
                """;

            //SELEct を実行し、複数行の検索結果を読み取る
            using var reader = command.ExecuteReader();

            while (reader.Read()) {
                products.Add(new CarReport {
                    Id = reader.GetInt32(0), //0列目:Id
                    Date = reader.GetDateTime(1),//1列目:Date
                    Author = reader.GetString(2),//2列目:Maker
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),//3列目:Auther
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    //Picture = reader.GetB(6)

                });

            }
            return products;
        }

    }
}
