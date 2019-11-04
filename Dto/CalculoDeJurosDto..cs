using CalculadoraDeJuros.Contratos.Errors.Hiper.Domain.Base.Errors;

namespace CalculadoraDeJuros.Contratos.Dto
{
    public class CalculoDeJurosDto : BaseError
    {
        public decimal Resultado { get; set; }
    }
}