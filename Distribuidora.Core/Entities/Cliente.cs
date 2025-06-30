namespace Distribuidora.Core.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF_CNPJ { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }

        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
