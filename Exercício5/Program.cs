namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita uma frase ae magrão: ");
            
            string frase = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());
            Console.WriteLine(frase.Length);
            
            string[] primeirapalavra = frase.Split();
            Console.WriteLine(primeirapalavra[0]);

            string ultimapalavra = frase.Split(' ').Last();
            Console.WriteLine(ultimapalavra);

            Console.ReadLine();
        }
    }
}