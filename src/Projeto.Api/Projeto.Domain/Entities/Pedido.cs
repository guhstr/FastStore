using System;
using System.Collections.Generic;
using Projeto.Domain.Enums;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um pedido realizado por um cliente.
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Chave primária do pedido.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identificador do cliente que fez o pedido.
        /// </summary>
        public Guid ClienteId { get; set; }

        /// <summary>
        /// Cliente associado ao pedido.
        /// </summary>
        public Cliente Cliente { get; set; } = null!;

        /// <summary>
        /// Data em que o pedido foi realizado.
        /// </summary>
        public DateTime DataPedido { get; set; }

        /// <summary>
        /// Valor total do pedido.
        /// </summary>
        public decimal ValorTotal { get; set; }

        /// <summary>
        /// Status atual do pedido.
        /// </summary>
        public StatusPedido Status { get; set; }

        /// <summary>
        /// Identificador do pagamento associado (opcional).
        /// </summary>
        public Guid? PagamentoId { get; set; }

        /// <summary>
        /// Pagamento associado ao pedido (opcional).
        /// </summary>
        public Pagamento? Pagamento { get; set; }

        /// <summary>
        /// Coleção de itens deste pedido.
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
    }
}
