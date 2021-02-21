
namespace UtilityKnife.Converters
{
    public class FahrenheitToCelsius
    {
        public double FahrenheitToCelsiusConverter(double fahrenheitTemp)
        {
            // (F – 32) / 5/9
            var step1 = Calculator.Calculator.Subtract(fahrenheitTemp, 32);
            var step2 = Calculator.Calculator.Division(step1, 5.0);
            return Calculator.Calculator.Division(step2, 9.0);

        }
    }
}
