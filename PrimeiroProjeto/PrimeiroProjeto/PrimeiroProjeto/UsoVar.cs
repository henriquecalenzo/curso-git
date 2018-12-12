using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class UsoVar {
        int x = 10;
       // var y = 10;  //

        public static void TestaVar() {
            var y = 10;
            Console.WriteLine(y); // em método estático funcionou, não deu para declarar direto na classe;
        }
    }
}
