using Excercize03;
using TextFileProcesserDI;

var service = new Take20Processor();
var processor = new TextFileProcessor(service);
string filename = @"C:\Users\infosys\source\repos\OOP2026\Chapter15\演習問題\Excercize03\枕草子.txt";
processor.Run(filename);