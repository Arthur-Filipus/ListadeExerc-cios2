using System.Globalization;

namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma Frase: ");

            string frase = Console.ReadLine();

            TextInfo teste = new CultureInfo("pt-BR", false).TextInfo;

            Console.WriteLine(teste.ToTitleCase(frase));

            Console.ReadLine();
        }
    }
}