using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class UpdateCategoriaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }
    }
}
