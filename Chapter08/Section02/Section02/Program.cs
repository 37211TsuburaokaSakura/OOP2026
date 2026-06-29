namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var Lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(Lines);
            foreach (var word in we.Extract()) {
                Console.WriteLine(word);
            }
        }
    }
}
