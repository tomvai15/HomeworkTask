namespace TemperatureConversion
{
    public class CelsiusTemperature : ITemperature
    {
        public float Temperature { get; private set; }

        public CelsiusTemperature() { }
        public CelsiusTemperature(float temperature)
        {
            Temperature = temperature;
        }

        public float FromKelvin(float temperature)
        {
            return temperature - 273.15f;
        }

        public float ToKelvin()
        {
            return Temperature + 273.15f;
        }
    }
}