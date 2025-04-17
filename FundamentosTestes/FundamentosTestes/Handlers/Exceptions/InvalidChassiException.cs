namespace FundamentosTestes.Handlers.Exceptions;

internal sealed class InvalidChassiException : Exception
{
    //A mensagem passa para a base
    public InvalidChassiException(string message) : base(message)
    {

    }
}