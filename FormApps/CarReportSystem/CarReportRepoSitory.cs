using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CarReportSystem.CarReport;

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
                    //0列目:Id
                    Id = reader.GetInt32(0),

                    //1列目:Date
                    Date = DateTime.ParseExact(
                        reader.GetString(1),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture),

                    //2列目:Auther
                    Author = reader.GetString(2),

                    //3列目:Maker                
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),

                    //4列目;CarReport
                    CarName = reader.GetString(4),

                    //5列目:Report
                    Report = reader.GetString(5),

                    //6列目:Picture
                    Picture = reader.IsDBNull(6) ? null : BytesToImage(reader.GetFieldValue<Byte[]>(6))
                });

            }
            return products;
        }


        //レポートの追加
        public int Add(DateTime value, string text, CarReport carreport) {

            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();
            connection.Open();

            //sqlを実行するためのコマンドプロジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText =
                """
                INSERT INTO CarReports
                (Date,Author,Maker,CarName,Report,Picture)
                VALUES
                ($date,$author,$maker,$report,$picture);

                SELECT last_insert_rowid();
                """;
            SetCommand(carreport,command);
           

            //1つの値を返すsqlを実行する
            var result = command.ExecuteScalar();

            if (result is null)
                throw new InvalidOperationException("登録したレポートのIDを取得できませんでした");

            //SQLLiteのINTERGERはlongとして帰るため、intへ変換する
            return Convert.ToInt32((long)result);
        }

        public static void SetCommand(CarReport carreport, SqliteCommand command) {
            command.Parameters.AddWithValue($"date", carreport.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue($"author", carreport.Author);
            command.Parameters.AddWithValue($"maker", carreport.Maker);
            command.Parameters.AddWithValue($"report", carreport.Report);
        }

           

        public void Update(CarReport carreport) {
            //接続オブジェクトを生成する
            using var connection = Database.GetConnection();

            connection.Open();

            //sqlを実行するためのコマンドプロジェクトを作る
            using var command = connection.CreateCommand();

            command.CommandText =
                """
                SET Date = $date, Author = $author, maker = $maker,
                    CarName = $carName, Report = $report, Picture = $Picture
                WHERE Id = $id;
                """;
            SetCommand(carreport, command);

            //1つの値を返すsqlを実行する
            command.ExecuteNonQuery();

        }


        public void delete(int id) {
            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
                DELETE FROM CarReports
                WHERE Id = $id;
                """;

            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        // ImageをSQLiteへ保存できるbyte[]へ変換する
        private static byte[]? ImageToBytes(Image? image) {
            if (image is null) return null;

            using var stream = new MemoryStream();
            // DBへはPNG形式で保存
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        // SQLiteのBLOB（byte[]）をImageへ変換する
        private static Image BytesToImage(byte[] data) {
            using var stream = new MemoryStream(data);
            using var image = Image.FromStream(stream);
            // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
            return new Bitmap(image);
        }
    }

}
