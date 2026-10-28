using System.Net.WebSockets;
using TextFileProcesserDI;

var service = new LineCounterService();
var processor = new TextFileProcessor(service);
string filename = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section05\Program.cs";
processor.Run(filename);
