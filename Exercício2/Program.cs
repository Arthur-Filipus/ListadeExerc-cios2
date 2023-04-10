namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada uma string contendo uma frase, escreva um programa em C# que conte o número de palavras na frase e imprima o resultado.

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] teste = frase.Split(',', '.', '!', ' ');

            Console.WriteLine($"sua frase possui {teste.Length} palavras");

            Console.ReadLine();
        }
    }
}