﻿namespace Distribuidora.Core.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
