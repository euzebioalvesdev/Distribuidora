namespace Distribuidora.Application.DTOs
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int ClienteId { get; set; }
        public string? NomeCliente { get; set; }
        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } = string.Empty;
        public bool NotaFiscalEmitida { get; set; }
        public string? NumeroNotaFiscal { get; set; }
        public List<ItemVendaDTO> Itens { get; set; } = new();
    }
}
