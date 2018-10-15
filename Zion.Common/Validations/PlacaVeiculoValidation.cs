
using System.Text.RegularExpressions;

namespace Zion.Common.Validations
{
    public class PlacaVeiculoValidation
    {
        /// <summary>
        /// Já validando Mercosul formato AAA9A99
        /// </summary>
        /// <param name="placaVeiculo"></param>
        /// <returns></returns>
        public static bool IsValid(string placaVeiculo)
        {
            placaVeiculo = placaVeiculo.Replace("-", string.Empty);
            if (placaVeiculo.Length != 7) return false;

            Regex rgxPlaca = new Regex(@"^[a-zA-Z]{3}\d{1}\w{1}\d{2}$");
            return rgxPlaca.IsMatch(placaVeiculo);
        }
    }
}
