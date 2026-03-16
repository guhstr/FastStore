using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um produto à venda na loja.
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Chave primária do produto.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Descrição opcional do produto.
        /// </summary>
        public string? Descricao { get; set; }

        /// <summary>
        /// Preço unitário.
        /// </summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Quantidade em estoque.
        /// </summary>
        public int QuantidadeEstoque { get; set; }

        /// <summary>
        /// Identificador da categoria à qual o produto pertence (obrigatório).
        /// </summary>
        public Guid CategoriaId { get; set; }

        /// <summary>
        /// Categoria associada.
        /// </summary>
        public Categoria Categoria { get; set; } = null!;

        /// <summary>
        /// Identificador do fornecedor (opcional).
        /// </summary>
        public Guid? FornecedorId { get; set; }

        /// <summary>
        /// Fornecedor associado (opcional).
        /// </summary>
        public Fornecedor? Fornecedor { get; set; }

        /// <summary>
        /// Itens de pedido que referenciam este produto.
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
    }
}
