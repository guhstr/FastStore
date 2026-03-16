using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um cliente que realiza pedidos.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Chave primária do cliente.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Endereço de e‑mail.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Endereço (opcional).
        /// </summary>
        public string? Endereco { get; set; }

        /// <summary>
        /// Número de telefone (opcional).
        /// </summary>
        public string? NumeroTelefone { get; set; }

        /// <summary>
        /// Pedidos associados a este cliente.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
