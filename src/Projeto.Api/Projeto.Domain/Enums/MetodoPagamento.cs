namespace Projeto.Domain.Enums
{
    /// <summary>
    /// Enumeração que define os métodos de pagamento disponíveis.
    /// </summary>
    public enum MetodoPagamento
    {
        Pix = 1,
        Boleto = 2,
        CartaoCredito = 3,
        CartaoDebito = 4,
        Dinheiro = 5
    }
}
