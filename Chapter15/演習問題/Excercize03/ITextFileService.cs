using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcesserDI;
    public interface ITextFileService {
    void Initialize(string name);
    bool Execute(string line);
    void Terminate();
    
    }

