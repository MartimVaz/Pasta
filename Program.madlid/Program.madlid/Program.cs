using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.madlid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é a sua idade? ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("O pais onde nasceu? ");
            string nasceu = Console.ReadLine();
            Console.Write("Onde vive? ");
            string cidade = Console.ReadLine();
            Console.Write("Quantos irmaos? ");
            int irmaos = int.Parse(Console.ReadLine());

            Console.WriteLine("Então vamos resumir, o teu nome é " + nome + " e tens " + anos + " anos e nasceste em " + nasceu + " e vives em " + cidade + " e tens " + irmaos + " irmaos.");

            Console.ReadLine(); 
        }
    }
}
