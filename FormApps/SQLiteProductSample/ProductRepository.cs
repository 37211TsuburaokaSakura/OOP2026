using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Xml.Linq;

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

    //商品を追加する。CREATEに相当する
    //戻り値として自動採番されたIDを返す
    public int Add(string name, int price) {
        //接続オブジェクトを生成する
        using var connection = Database.GetConnection();

        connection.Open();

        //sqlを実行するためのコマンドプロジェクトを作る

        using var command = connection.CreateCommand();

        command.CommandText =
            """
             INSERT INTO Products(Name,Price)
             VALUES($name,$price);

             SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

        //1つの値を返すsqlを実行する
        var result = command.ExecuteScalar();

        if (result is null) 
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした");

        //SQLLiteのINTERGERはlongとして帰るため、intへ変換する
        return Convert.ToInt32((long)result);
    }

    public void Update(Product product) {
        //接続オブジェクトを生成する
        using var connection = Database.GetConnection();

        connection.Open();

        //sqlを実行するためのコマンドプロジェクトを作る

        using var command = connection.CreateCommand();

        command.CommandText =
            """
             UPDATE Products
             SET Name = $name,
                 Price  = $price
             WHERE Id = $id;

            """;

        command.Parameters.AddWithValue("$name", product.Name);
        command.Parameters.AddWithValue("$price", product.Price);
        command.Parameters.AddWithValue("$id", product.Id);

        //1つの値を返すsqlを実行する
        command.ExecuteNonQuery();
    }
}
