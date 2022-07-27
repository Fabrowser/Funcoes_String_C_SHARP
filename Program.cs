using System;

namespace Funcoes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG  ";
            string s = "You win some. You lose some.";
            string[] subs = s.Split(' '); // Corta a string s com base em espaçoes em branco

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // Apaga espaçoes em branco na borda da string
            string s4 = original.Substring(3); // Corta a string a partir do inicio começando em 0
            string s5 = original.Substring(3,5); // Corta a string a partir do inicio começando em 0
            string s6 = original.Replace('a','x'); // Substitui caractere denstro da string
            string s7 = original.Replace("abc","xy"); // Substitui string denstro da string
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            double f1 = 2;


            Console.WriteLine("Original: " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("indexOf ('bc') " + n1);
            Console.WriteLine("LastIndexOf ('bc): " + n2);
            Console.WriteLine("Substring 3 : " + s4);
            Console.WriteLine("Substring 3,5 : " + s5);
            Console.WriteLine("Replace (a por x)  : " + s6);
            Console.WriteLine("Replace (abc por xy)  : " + s7);
            Console.WriteLine("IsnullOrEmpty : " + b1);
            Console.WriteLine("IsNullOrWhiteSpace : " + b2);
            Console.WriteLine("Formatação de Valor: " + f1.ToString("C2"));




            //percorre o vetor de string para exibir o corte de string
            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring e Split: {sub}");
            }



        }
    }
}
