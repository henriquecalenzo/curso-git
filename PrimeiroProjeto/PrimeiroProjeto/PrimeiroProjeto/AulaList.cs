using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class AulaList {

        private string lookingFor = "";
        private char firstLetter;

        private List<string> ListNames;

        public AulaList(string[] pNames) {
            ListNames = RiseList(pNames);
        }

        public List<string> GetListNames() {
            return ListNames;
        }


        public List<string> RiseList(String[] pNames) {
            List<string> listnames = new List<string>();

            foreach (string name in pNames) {
                listnames.Add(name);
            }
            return listnames;
        }

        public string FindOnList (string pName) {
            //estudar função predicado
            lookingFor = pName;
            return ListNames.Find(HasOnList);
        }

        public string FindOnListResume(string pName) {
            //estudar função predicado
            return ListNames.Find(listitem => listitem.Equals(pName));
        }

        public string FindFirstLetter(char pLetter) {
            //estudar função predicado
            firstLetter = pLetter;
            return ListNames.Find(HasFirstLetter);
        }

        public string FindFirstLetterResume(char pLetter) {
            //estudar função predicado
            return ListNames.Find(listitem => listitem[0] == pLetter);
        }

        private bool HasOnList(string pItemList) {
            return pItemList.Contains(lookingFor);
        }

        private bool HasFirstLetter(string pItemList) {
            return pItemList[0] == firstLetter;
        }

    }
}
