


namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            Console.WriteLine(" --- 4.1.1 ---");

            //foreach文
            Console.WriteLine("foreach文で出力");
            var cought = langs.Where(s => s.Contains('S') ).ToArray();
            foreach (var language in cought) {
                Console.WriteLine(language);

            }




            //for文
            Console.WriteLine("\nfor文で出力");
            var ca = langs.Where(s => s.Contains('S')).ToArray();
            for (int i = 0; i < ca.Length; i++) {
                Console.WriteLine(ca[i]);
            }





            //while文
            Console.WriteLine("\nwhile文で出力");
            var get = langs.Where(s => s.Contains('S')).ToArray();
            int j = 0;
            while (j < ca.Length) {
                j++;
                Console.WriteLine(get);

            }


        }

        private static void Exercise2(List<string> langs) {
            Console.WriteLine("\n --- 4.1.2 ---");
            //LINQを使用する（Where）


        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("\n --- 4.1.3 ---");

        }
    }
}
