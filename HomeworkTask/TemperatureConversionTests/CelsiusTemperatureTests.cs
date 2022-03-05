using Xunit;
using TemperatureConversion;

namespace TemperatureConversionTests
{
    public class CelsiusTemperatureTests
    {
        [Theory]
        [InlineData(-273.15f, 0)]
        [InlineData(0, 273.15f)]
        [InlineData(-150, 123.15f)]
        [InlineData(100, 373.15f)]
        public void ToKelvinTest(float temperature, float expectedKelvinTemp)
        {
            int precision = 3;
            var celsiusTemperature = new CelsiusTemperature(temperature);

            float calculatedTemperature = celsiusTemperature.ToKelvin();

            Assert.Equal(expectedKelvinTemp, calculatedTemperature, precision);

        }

        [Theory]
        [InlineData(0, -273.15f)]
        [InlineData(100, -173.15)]
        [InlineData(273.15, 0)]
        [InlineData(400, 126.85f)]
        public void FromKelvinTest(float temperature, float expectedCelsiusTemp)
        {
            int precision = 3;
            var celsiusTemperature = new CelsiusTemperature();

            float calculatedTemperature = celsiusTemperature.FromKelvin(temperature);

            Assert.Equal(expectedCelsiusTemp, calculatedTemperature, precision);

        }

    }
}