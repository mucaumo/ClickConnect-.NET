namespace ClickConnect.Models
{
    public class Produto : IProduto
    {
        private static List<Produto> ListaProdutos = new List<Produto>();
        private static List<Produto> LojasParceiras = new List<Produto>();
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }

        public Produto(double preco, int quantidade, string nome, string marca, string cor)
        {
            Preco = preco;
            Quantidade = quantidade;
            Nome = nome;
            Marca = marca;
            Cor = cor;
        }

        public virtual void Cadastrar() {

            ListaProdutos.Add(this);
            System.Console.WriteLine("Cadastro realizado com sucesso! ");
            
        }

        public void Listar()
        {   
            System.Console.WriteLine(ListaProdutos);
        }

        internal void VerificandoLojasParceiras(string loja)
        {
            LojasParceiras.Add(this);
            System.Console.WriteLine("Loja encontrada! ");
        }
    }
}
