namespace salesCalculator {
    internal class Program {
        static void Main(string[] args) {

            var sales = new SalesCounter(@"date\sales.csv");
            Dictionary<String, int> amountPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string,int> obj in amountPerStore){
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }
        }


    }
}
