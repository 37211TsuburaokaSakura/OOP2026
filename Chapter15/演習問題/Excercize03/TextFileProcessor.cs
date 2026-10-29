using Excercize03;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcesserDI {
    internal class TextFileProcessor {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }

        public void Run(string fileName) {
            _service.Initialize(fileName);
            var lines = File.ReadLines(fileName);

            foreach (var line in lines) {
              ;
                if (!_service.Execute(line)) {
                    break;
                }

              

            }
            _service.Terminate();
        }
    }
}

