using Xunit;
using TemperatureConversion;

namespace TemperatureConversionTests
{
    public class FahrenheitTemperatureTests
    {
        [Theory]
        [InlineData(-459.67f, 0)]
        [InlineData(-100, 199.817f)]
        [InlineData(0, 255.372f)]
        [InlineData(212, 373.15f)]
        public void ToKelvinTest(float temperature, float expectedKelvinTemp)
        {
            int precision = 3;
            var fahrenheitTemperature = new FahrenheitTemperature(temperature);

            float calculatedTemperature = fahrenheitTemperature.ToKelvin();

            Assert.Equal(expectedKelvinTemp, calculatedTemperature, precision);

        }

        [Theory]
        [InlineData(0, -459.67f)]
        [InlineData(100, -279.67)]
        [InlineData(255.372f, 0)]
        [InlineData(400, 260.33f)]
        public void FromKelvinTest(float temperature, float expectedFahrenheitTemp)
        {
            int precision = 3;
            var fahrenheitTemperature = new FahrenheitTemperature();

            float calculatedTemperature = fahrenheitTemperature.FromKelvin(temperature);

            Assert.Equal(expectedFahrenheitTemp, calculatedTemperature, precision);

        }
    }
}
