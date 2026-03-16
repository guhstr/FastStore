using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa uma categoria de produtos.
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Chave primária da categoria.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome da categoria.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Descrição opcional da categoria.
        /// </summary>
        public string? Descricao { get; set; }

        /// <summary>
        /// Produtos associados a esta categoria.
        /// </summary>
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
