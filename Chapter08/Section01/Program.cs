
namespace Section01 {
    internal class Program {
        private static Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();
        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine($"県庁所在地の登録【入力終了：Ctrl+'Z'】");

            while (true) {
                //都道府県　入力
                Console.Write("都道府県：");
                pref = Console.ReadLine();

                if (pref == null) break;


                //2 県庁所在地の入力
                Console.Write("県庁所在地：");
                prefCaptalLocation = Console.ReadLine();

                //県庁所在地登録処理
                prefOfficeDict[pref] = prefCaptalLocation;
            }



            while (true) {
                switch (menuDisp()) {
                    case 1:
                        foreach (var item in prefOfficeDict) {
                            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
                        }
                        break;
                    case 2:
                        Console.Write("都道府県:");
                        var key = Console.ReadLine();
                        if (prefOfficeDict.ContainsKey(key)) {
                            var search = prefOfficeDict[key];
                            Console.WriteLine($"{key}の県庁所在地は{search}です");
                        }
                        break;
                    case 9:
                        return;
                        
                        
                }
                
            }
        }

        private static int menuDisp() {
            Console.WriteLine("****メニュー****");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9:終了");
            Console.Write(">");
            var numnum = Console.ReadLine();
            int numnum2 = int.Parse(numnum);
            return numnum2;
        }
    }
}
