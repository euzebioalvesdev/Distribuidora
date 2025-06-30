using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Application.DTOs
{
    public class CreateClienteDTO
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string CPF_CNPJ { get; set; } = string.Empty;

        [EmailAddress]
        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }
    }
}
