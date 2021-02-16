
namespace UtilityKnife.Converters
{
    public class FahrenheitToCelsius
    {
        public double FahrenheitToCelsiusConverter(double fahrenheitTemp)
        {
            double _celsius = 0.0;

            // (F – 32) / 5/9

            var step1 = Calculator.Calculator.Subtract(fahrenheitTemp, 32);
            var step2 = Calculator.Calculator.Division(step1, 5.0);
            _celsius = Calculator.Calculator.Division(step2, 9.0);
            return _celsius;
        }
    }
}
