using Xunit;
using TemperatureConversion;

namespace TemperatureConversionTests
{
    public class KelvinTemperatureTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(15, 15)]
        [InlineData(150, 150)]
        public void ToKelvinTest(float temperature, float expectedKelvinTemp)
        {
            int precision = 3;
            var klevinTemperature = new KelvinTemperature(temperature);

            float calculatedTemperature = klevinTemperature.ToKelvin();

            Assert.Equal(expectedKelvinTemp, calculatedTemperature, precision);

        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(15, 15)]
        [InlineData(150, 150)]
        public void FromKelvinTest(float temperature, float expectedKelvinTemp)
        {
            int precision = 3;
            var klevinTemperature = new KelvinTemperature();

            float calculatedTemperature = klevinTemperature.FromKelvin(temperature);

            Assert.Equal(expectedKelvinTemp, calculatedTemperature, precision);

        }
    }
}
