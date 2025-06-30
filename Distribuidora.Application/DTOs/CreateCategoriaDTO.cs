using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class CreateCategoriaDTO
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }
    }
}
