



namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];


            Console.WriteLine("\n7.1.1");
            Exercise1(numbers);

            Console.WriteLine("\n7.1.2");
            Exercise2(numbers);

            Console.WriteLine("\n7.1.3");
            Exercise3(numbers);

            Console.WriteLine("\n7.1.4");
            Exercise4(numbers);

            Console.WriteLine("\n7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers) {
            var maxnums = numbers.Max();
            Console.WriteLine(maxnums);
        }

        private static void Exercise2(int[] numbers) {
           
            
            foreach (var item in numbers.TakeLast(2)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3(int[] numbers) {
            //p173 参照
            var change = numbers.Select(x => x.ToString("000"));
            foreach (var item in change) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise4(int[] numbers) {
            
            foreach (var item in numbers.Order().Take(3)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise5(int[] numbers) {
            var deletenum = numbers.Distinct().Count(x => x > 10);
            
                Console.WriteLine(deletenum);
            
        }
    }
}
