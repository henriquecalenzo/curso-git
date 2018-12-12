using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class Produto {
        private string nome;
        private float preco;
        private int quantidade;

        public float GetPreco() {
            return preco;
        }

        public void SetPreco(float value) {
            preco = value;
        }

        public int GetQuantidade() {
            return quantidade;
        }

        public void SetQuantidade(int value) {
            quantidade = value;
        }

        public string GetNome() {
            return nome;
        }

        public void SetNome(string value) {
            nome = value;
        }


    }
}
