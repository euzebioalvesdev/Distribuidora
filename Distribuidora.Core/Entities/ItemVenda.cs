﻿namespace Distribuidora.Core.Entities
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal Subtotal => Quantidade * PrecoUnitario;
    }
}
