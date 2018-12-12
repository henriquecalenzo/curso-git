using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class SetClass {
        //Conjunto não permite repetição, não tem posição;

        public HashSet<int> CreateSetInt(int[] pIntElements) {

            HashSet<int> localhash = new HashSet<int>();

            foreach (int val in pIntElements) {
                localhash.Add(val);
            }

            return localhash;
        }
    }
}
