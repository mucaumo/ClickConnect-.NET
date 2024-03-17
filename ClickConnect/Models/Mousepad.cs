namespace ClickConnect.Models
{
    public class Mousepad : Produto
    {
        public Mousepad(int id, string tamanho, string tipo, double preco, int quantidade, string nome, string marca, string cor) : base(preco, quantidade, nome, marca, cor)
        {
            Id = id;
            Tipo = tipo;
            Tamanho = tamanho;
        }

        public int Id { get; set; }
        public string Tamanho { get; set; }
        public string Tipo { get; set; }

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine("Produto cadastrado com sucesso! ");
        }
    }
}
