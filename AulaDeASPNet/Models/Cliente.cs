namespace AulaDeASPNet.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP {  get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
