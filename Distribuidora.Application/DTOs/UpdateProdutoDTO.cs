using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class UpdateProdutoDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }

        [Required]
        public string CodigoBarras { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue)]
        public decimal PrecoVenda { get; set; }

        [Range(0, double.MaxValue)]
        public decimal PrecoCusto { get; set; }

        [Range(0, int.MaxValue)]
        public int QuantidadeEstoque { get; set; }

        [Required]
        public string UnidadeMedida { get; set; } = string.Empty;

        [Required]
        public int CategoriaId { get; set; }
    }
}
