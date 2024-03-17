namespace ClickConnect.Models
{
    public class Teclado : Produto
    {
        public Teclado(int id, string tipoSwitch, double preco, int quantidade, string nome, string marca, string cor) : base(preco, quantidade, nome, marca, cor)
        {
            Id = id;
            TipoSwitch = tipoSwitch;
        }

        public int Id { get; set; }
        protected string Modelo { get; set; }
        public string TipoSwitch { get; set; }

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
