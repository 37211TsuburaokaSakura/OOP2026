namespace exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n ---4.2.1---");
            Exercise1();
            Console.WriteLine("\n ---4.2.2---");
            Exercise2();
            Console.WriteLine("\n ---4.2.3---");
            Exercise3();
        }

        //p80~90を参考にする
        private static void Exercise1() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                if (num <= 0) {
                    Console.WriteLine(num);
                } else if (num < 100) {
                    Console.WriteLine((num * 2));
                } else if (num >= 100) {
                    Console.WriteLine(num * 3);
                } else {
                    Console.WriteLine(num);

                }
            } else {
                Console.WriteLine("入力値に謝りがあります");
            }
        }

        private static void Exercise2() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                switch (num) {
                    case < 0:
                        Console.WriteLine(num);
                        break;
                    case < 100:
                        Console.WriteLine((num * 2));
                        break;
                    case < 500:
                        Console.WriteLine(num * 3);
                        break;
                    default:
                        Console.WriteLine(num);
                        break;
                }
            } else {
                Console.WriteLine("入力値に謝りがあります");
            }
        }

        private static void Exercise3() {
            var num = Console.ReadLine;
        }
    }
}
