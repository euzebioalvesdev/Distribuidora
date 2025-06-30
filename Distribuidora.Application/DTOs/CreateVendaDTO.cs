using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class CreateVendaDTO
    {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        public string FormaPagamento { get; set; } = string.Empty;

        [Required]
        public List<CreateItemVendaDTO> Itens { get; set; } = new();
    }
}
