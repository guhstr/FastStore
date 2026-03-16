using System;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um item de pedido, associando um produto a um pedido com quantidade e preço.
    /// </summary>
    public class ItemPedido
    {
        /// <summary>
        /// Chave primária do item de pedido.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identificador do pedido (obrigatório).
        /// </summary>
        public Guid PedidoId { get; set; }

        /// <summary>
        /// Pedido associado.
        /// </summary>
        public Pedido Pedido { get; set; } = null!;

        /// <summary>
        /// Identificador do produto (obrigatório).
        /// </summary>
        public Guid ProdutoId { get; set; }

        /// <summary>
        /// Produto associado.
        /// </summary>
        public Produto Produto { get; set; } = null!;

        /// <summary>
        /// Quantidade de unidades do produto.
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Preço unitário praticado no pedido.
        /// </summary>
        public decimal PrecoUnitario { get; set; }

        /// <summary>
        /// Valor total do item (PreçoUnitario * Quantidade).
        /// </summary>
        public decimal PrecoTotal => PrecoUnitario * Quantidade;
    }
}
