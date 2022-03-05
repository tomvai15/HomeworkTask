using Xunit;
using TemperatureConversion;

namespace TemperatureConversionTests
{
    public class TemperatureConverterTests
    {
        [Theory]
        [InlineData(-100, -148)]
        [InlineData(0, 32)]
        [InlineData(150, 302)]
        public void ConvertTo_CelsiusToFahrenheit(float temperature, float expectedFahrenheitTemp)
        {
            int precision = 3;
            var celsiusTemperature = new CelsiusTemperature(temperature);

            float calculatedTemperature = TemperatureConverter.ConvertTo<FahrenheitTemperature>(celsiusTemperature);

            Assert.Equal(expectedFahrenheitTemp, calculatedTemperature, precision);
        }
        [Theory]
        [InlineData( -148, -100)]
        [InlineData( 32,0)]
        [InlineData( 302, 150)]
        public void ConvertTo_FahrenheitToCelcius(float temperature, float expectedCelsiusTemp)
        {
            int precision = 3;
            var fahrenheitTemperature = new FahrenheitTemperature(temperature);

            float calculatedTemperature = TemperatureConverter.ConvertTo<CelsiusTemperature>(fahrenheitTemperature);

            Assert.Equal(expectedCelsiusTemp, calculatedTemperature, precision);

        }

        [Theory]
        [InlineData(0, -459.67f)]
        [InlineData(100, -279.67)]
        [InlineData(255.372f, 0)]
        [InlineData(400, 260.33f)]
        public void ConvertTo_KelvinToFahrenheit(float temperature, float expectedFahrenheitTemp)
        {
            int precision = 3;
            var kelvinTemperature = new KelvinTemperature(temperature);

            float calculatedTemperature = TemperatureConverter.ConvertTo<FahrenheitTemperature>(kelvinTemperature);

            Assert.Equal(expectedFahrenheitTemp, calculatedTemperature, precision);
        }
        [Theory]
        [InlineData(-273.15f, 0)]
        [InlineData(0, 273.15f)]
        [InlineData(-150, 123.15f)]
        [InlineData(100, 373.15f)]
        public void ConvertTo_CelsiusToKelvin(float temperature, float expectedKelvinTemp)
        {
            int precision = 3;
            var celsiusTemperature = new CelsiusTemperature(temperature);

            float calculatedTemperature = TemperatureConverter.ConvertTo<KelvinTemperature>(celsiusTemperature);

            Assert.Equal(expectedKelvinTemp, calculatedTemperature, precision);
        }
    }
}
