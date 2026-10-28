using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcesserDI;

namespace Excercize03 {
    internal class Take20Processor : ITextFileService {
        private int _count;


        public void Initialize(string name) => _count = 0;

        public void Execute(string line) {
            _count++;
            if (_count <= 20) {
               // foreach (var luup in  ) { }
                Console.WriteLine(line);
            }
        }


        public void Terminate() {
            Console.WriteLine(_count);

        }
    }
}
