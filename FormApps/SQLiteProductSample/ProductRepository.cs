using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

//Productテーブルに対するDB操作をまとめたクラス
//CRUD (Create / Read / Update / Delete)
public class ProductRepository {
    public List<Product> GetAll() {

        var products = new List<Product>();

        using var connection = Database.GetConnection();
        connection.Open();

        //sqlを実行するためのコマンドプロジェクトを作る

        using var command = connection.CreateCommand();



        //productテーブルを作るｓｑl
        command.CommandText =
            """
            SELECT Id,Name,Price
            FROM Products
            ORDER BY Id;
            """;

        //SELEct を実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            products.Add(new Product {
                Id = reader.GetInt32(0), //0列目:Id
                Name = reader.GetString(1),//1列目:Name
                Price = reader.GetInt32(2)//2列目:Price

            });

        }
        return products;
    }
}
