using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class CreateItemVendaDTO
    {
        [Required]
        public int ProdutoId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantidade { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal PrecoUnitario { get; set; }
    }
}
