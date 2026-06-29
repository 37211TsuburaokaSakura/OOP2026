


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

                //上書き
                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますかＹ/Ｎ");
                    if (Console.ReadLine() == "N") continue;
                }

                //県庁所在地登録処理
                prefOfficeDict[pref] = prefCaptalLocation;
            }


            Boolean endFlag = false;
            while (true) {
                switch (menuDisp()) {
                    case 1:
                        //一覧表示
                        allDisp();
                        break;

                    case 2:
                        //検索
                        seachPrefCaptalLocation();
                        break;

                    default:
                        endFlag = true;
                        break;
                }
            }
        }

        //case2
        private static void seachPrefCaptalLocation() {
            Console.Write("都道府県:");
            var key = Console.ReadLine();
            if (prefOfficeDict.ContainsKey(key)) {
                var search = prefOfficeDict[key];
                Console.WriteLine($"{key}の県庁所在地は{search}です");
            }
        }

        //case1
        private static void allDisp() {
            foreach (var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
            }
        }

        //メニュー
        private static int menuDisp() {
            Console.Write("\n");
            Console.WriteLine("****メニュー****");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9:終了");
            Console.Write(">");

            int numnum = int.Parse(Console.ReadLine());
            return numnum;
        }
    }
}
