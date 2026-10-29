using Excercize03;
using TextFileProcesserDI;

var service = new Take20Processor();
var processor = new TextFileProcessor(service);
string filename = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\Exercise01_WPF\吾輩は猫である.txt";
processor.Run(filename);