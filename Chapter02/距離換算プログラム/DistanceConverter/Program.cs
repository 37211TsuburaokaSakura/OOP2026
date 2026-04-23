using System.ComponentModel.Design;

namespace DistanceConverter {
    internal class Progra {
        static void Main(string[] args) {

            if (args.Length == 3
                && int.TryParse(args[1], out int start)
                && int.TryParse(args[2], out int end)) {

                if (args[0] == "-tom") {
                    PrintFeetToMeterList(start, end);
                }
                else if (args[0] == "-tof") {
                    PrintFeetToMeterList(start, end);
                }
                else {
                    Console.WriteLine("引数エラー");
                }
            }
        }

        /*
   if (args.Length >= 1 && args[0] == "-tom"){
           PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
       }
       else if (args.Length >= 1 && args[0] == "-tof"){
           PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
       }
       else
       {
           Console.WriteLine("引数エラー");
       }
}
*/

        //フィートからメートルへの対応表を出力
        static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                
                double meter = converter.FromMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
        //メートルからフィートの対応表を出力
        static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter converter = new FeetConverter();
            
            for (int meter = start; meter <= stop; meter++) {
                double feet = Convert.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

    }
}
