using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Representa um fornecedor de produtos.
    /// </summary>
    public class Fornecedor
    {
        /// <summary>
        /// Chave primária do fornecedor.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome do fornecedor.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// E‑mail de contato (opcional).
        /// </summary>
        public string? EmailContato { get; set; }

        /// <summary>
        /// Número de telefone (opcional).
        /// </summary>
        public string? NumeroTelefone { get; set; }

        /// <summary>
        /// Coleção de produtos fornecidos por este fornecedor.
        /// </summary>
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
