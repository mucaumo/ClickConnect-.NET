namespace ClickConnect.Models
{
    public class Mouse : Produto
    {
        public Mouse(int id, string tamanho, string sensor, double preco, int quantidade, string nome, string marca, string cor) : base(preco, quantidade, nome, marca, cor)
        {
            Id = id;
            Tamanho = tamanho;
            Sensor = sensor;
        }

        public int Id { get; set; }
        public string Tamanho { get; set; }
        public string Sensor { get; set; }

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine("Produto cadastrado! ");
        }
    }
}
