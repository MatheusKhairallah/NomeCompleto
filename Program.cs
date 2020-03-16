using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome=Console.ReadLine();

            Console.ReadKey();

            Console.Write("Agora digite seu sobrenome: ");
            string sobrenome=Console.ReadLine();
            string sobrenome2=sobrenome.ToUpper();

            Console.Clear();
            
            string mensagem="Nome completo: " +nome+ " " +sobrenome+ ".";

            Console.WriteLine(mensagem);

            string mensagem2="Nome de catálogo: " +sobrenome2+ ", " +nome+ ".";

            Console.WriteLine(mensagem2);
        }
    }
}
