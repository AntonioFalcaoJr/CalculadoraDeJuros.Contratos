using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Errors.Hiper.Domain.Base.Errors;

namespace CalculadoraDeJuros.Contratos.Dto
{
    public class TaxaDeJurosDto : BaseError
    {
        public ITaxaDeJuros TaxaDeJuros { get; set; }
        public decimal Valor { get; set; }
    }
}