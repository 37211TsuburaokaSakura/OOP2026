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

        public bool Execute(string line) {
         
            Console.WriteLine(line);
            _count++;

            return _count < 20;
            
        }

        public void Terminate() {
            Console.WriteLine(_count);

        }
    }
}
