namespace Section01 {
    internal class Program {


        static void Main(string[] args) {

            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };


           var exists = cities.Exists(s => 6 <= s.Length && s.Contains('o') && s.EndsWith('n'));
            Console.WriteLine(exists);


            /*
                       var name = cities.Find(s => s.Length == 6);
                       Console.WriteLine(name);


                       int index = cities.FindIndex(s => s == "Berlin");
                       Console.WriteLine(index);


                       var names = cities.FindAll(s => s.Length <= 5);
                       foreach (var s in names) {
                           Console.WriteLine(s);
                       }

                       */
        }
        //文字数が6字以上
        //0を含む
        //最後がｎ
    }

}
