
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy Iummox gives smart squid who asks for job pen";

            Exercise01(text);
            Console.WriteLine();
            Exercise02(text);
        }

        private static void Exercise01(string text) {
            //8.1.1
            /*  var key = Enumerable.Range('A', 26)
                                       .Select((num) => ((char)num).ToString())
                                       .ToList();
            */
            // Dictionaryを準備
            var numDic = new Dictionary<char, int>();
            foreach (var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (numDic.ContainsKey(ch)) {
                        numDic[ch]++;
                    } else {
                        numDic[ch] = 1;
                    }
                }               
            }
            foreach (var item in numDic.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
        private static void Exercise02(string text) {
            var numDic = new SortedDictionary<char, int>();
            foreach (var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (numDic.ContainsKey(ch)) {
                        numDic[ch]++;
                    } else {
                        numDic[ch] = 1;
                    }
                }
            }
            foreach (var item in numDic) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
    
}
