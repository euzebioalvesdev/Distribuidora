namespace Distribuidora.Core.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string CodigoBarras { get; set; } = string.Empty;
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string UnidadeMedida { get; set; } = string.Empty;

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
