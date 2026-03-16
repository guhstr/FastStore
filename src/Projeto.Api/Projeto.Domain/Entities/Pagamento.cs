using System;
using Projeto.Domain.Enums;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um pagamento associado a um pedido.
    /// </summary>
    public class Pagamento
    {
        /// <summary>
        /// Chave primária do pagamento.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Identificador do pedido ao qual o pagamento pertence (obrigatório).
        /// </summary>
        public Guid PedidoId { get; set; }

        /// <summary>
        /// Pedido associado.
        /// </summary>
        public Pedido Pedido { get; set; } = null!;

        /// <summary>
        /// Data em que o pagamento foi efetuado.
        /// </summary>
        public DateTime DataPagamento { get; set; }

        /// <summary>
        /// Valor do pagamento.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Método de pagamento utilizado.
        /// </summary>
        public MetodoPagamento MetodoPagamento { get; set; }
    }
}
