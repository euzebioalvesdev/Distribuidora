namespace Distribuidora.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string UnidadeMedida { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public string? NomeCategoria { get; set; }  // opcional para exibição
    }
}
