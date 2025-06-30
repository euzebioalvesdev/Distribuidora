namespace Distribuidora.Core.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } = string.Empty;
        public bool NotaFiscalEmitida { get; set; }
        public string? NumeroNotaFiscal { get; set; }

        public ICollection<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
    }
}
