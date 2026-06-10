using System.Net.WebSockets;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            var read = Console.ReadLine();

            if (int.TryParse(read, out var result)) {
                int num = result;
                var s1 = num.ToString("#,0");
                Console.WriteLine(s1);

            } else {
                Console.WriteLine("数字文字列に変換できません");
               
            }
        }
    }
}
