namespace AulaDeASPNet.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Qtde { get; set; }
        public decimal Peso { get; set; }
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }
    }
}
