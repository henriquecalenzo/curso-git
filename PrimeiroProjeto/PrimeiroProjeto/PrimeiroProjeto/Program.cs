using System;

namespace PrimeiroProjeto {
    class Program {

        static void Main(string[] args) {
            //Console.WriteLine("Hello World!");

            Produto prod = new Produto();
            Console.Write("Digite nomes: ");
            string names = Console.ReadLine();


            Console.WriteLine("Você digitou os nomes: " + names);

            string[] vetPhrase = names.Split(" ");

            foreach(string word in vetPhrase) {
                Console.WriteLine("Você digitou: " + word);
            }

            AulaList ClassList = new AulaList(vetPhrase);

            Console.WriteLine("1o Nome com Letra A: " + ClassList.FindFirstLetter('A'));

            Console.WriteLine("1o Nome com Letra B: " + ClassList.FindFirstLetterResume('B'));

            Console.WriteLine("1o Nome com Letra ex: " + ClassList.FindOnList("ex"));
            Console.WriteLine("1o Nome com Letra Al: " + ClassList.FindOnList("Al"));

            Console.WriteLine("Digite o número de linhas da matrix:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas da matrix:");
            int colunas = int.Parse(Console.ReadLine());

            ClassMatrix classmatrix = new ClassMatrix();
            double[,] matrixdouble = classmatrix.CreateMatrix(3, 4);

            Console.WriteLine("Lenght Matrix: " + matrixdouble.Length);
            Console.WriteLine("Rank Matrix: " + matrixdouble.Rank);
            Console.WriteLine("GetLenght(0) Matrix: " + matrixdouble.GetLength(0));
            Console.WriteLine("GetLenght(1) Matrix: " + matrixdouble.GetLength(1));

            Console.WriteLine("Testando Check Out 2");

        }
    }
}
