using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                
            }








        }

        private static void Exercise02(string text) {

        }
    }
}
