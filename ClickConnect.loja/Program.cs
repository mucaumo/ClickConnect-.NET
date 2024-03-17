namespace ClickConnect.loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da loja");
            var loja = Console.ReadLine();

            if (loja == "ClickConnect") {
                Console.WriteLine("Loja Existente!");
            }
        }
    }
}
