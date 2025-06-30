using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class UpdateVendaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public string FormaPagamento { get; set; } = string.Empty;

        public bool NotaFiscalEmitida { get; set; }

        public string? NumeroNotaFiscal { get; set; }

        [Required]
        public List<UpdateItemVendaDTO> Itens { get; set; } = new();
    }
}
